using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Market
{
    internal enum ActionType { Select, Buy, Null }

    public class Shop : MonoBehaviour
    {
        [SerializeField] private TMP_Text skinName;
        [SerializeField] private TMP_Text priceText;
        [SerializeField] private TMP_Text coinsText;
        
        [SerializeField] private Image skinColorDisplay; 
        [SerializeField] private SkinsStorage storage;

        private ShopDataStorage _data;
        private ActionType _action; 
        
        private int _secondSkinIndex; 
        private Skin _currentSkin;
        
        private void OnEnable()
        {
            _data = new ShopDataStorage();
            _secondSkinIndex = 0; 
            
            if (PlayerPrefs.HasKey("score"))
                coinsText.text = PlayerPrefs.GetInt("score").ToString();
            
            _currentSkin = storage.skins[_secondSkinIndex];
            UpdateDisplay();
        }

        public void SwitchSkin(int up)
        {
            if (_secondSkinIndex >= storage.skins.Length-1 && up > 0) return; 
            if (_secondSkinIndex <= 0 && up < 0 ) return;
            
            _secondSkinIndex += up;
            _currentSkin = storage.skins[_secondSkinIndex];
            UpdateDisplay();
        }

        public void Interact()
        {
            switch (_action)
            {
                case ActionType.Select:
                    _data.SaveSecondSkin(_secondSkinIndex);
                    _data.Refresh();
                    
                    UpdateDisplay();
                    break;
                case ActionType.Buy:
                    if (!PlayerPrefs.HasKey("score") || PlayerPrefs.GetInt("score") <= _currentSkin.skinPrice) return; 
                    
                    var coins = PlayerPrefs.GetInt("score");
                    coins -=  _currentSkin.skinPrice;
                    PlayerPrefs.SetInt("score", coins);
                    
                    coinsText.text = PlayerPrefs.GetInt("score").ToString();
                    _data.AddNewSkin(_secondSkinIndex);
                    _data.SaveSecondSkin(_secondSkinIndex);
                    _data.Refresh();
                    
                    UpdateDisplay();
                    break;
            }
        }

        private void UpdateDisplay()
        {
            skinName.text = _currentSkin.skinName; 
            priceText.text = DisplayPriceButton(_currentSkin.skinPrice);
            skinColorDisplay.color = _currentSkin.skinColor;
        }

        private string DisplayPriceButton(int price)
        {
            if (_secondSkinIndex == _data.SecondSkin)
            {
                _action = ActionType.Null;
                return "Selected"; 
            }
            
            foreach (var el in _data.PurchasedSkins)
            {
                if (el == _secondSkinIndex)
                {
                    _action = ActionType.Select;
                    return "Equip";
                }
            }
            
            _action = ActionType.Buy;
            return price.ToString();
        }
    }
}