using System.Collections.Generic;
using UnityEngine;
using VRKDEV.PlayerPrefsPro;

namespace Market
{
    internal struct ShopDataKeys
    {
        public const string PurchasedKey = "purch_array";
        public const string SelectedSkinKey = "selected"; 
    }
    
    public class ShopDataStorage
    {
        private int _secondSkin; 
        private List<int> _purchasedSkins;
        
        public int SecondSkin => _secondSkin;
        public List<int> PurchasedSkins => _purchasedSkins;
        
        public ShopDataStorage()
        {
            Refresh();
        }

        public void SaveSecondSkin(int skin) => PlayerPrefs.SetInt(ShopDataKeys.SelectedSkinKey, skin);

        private int LoadSecondSkin()
        {
            if (!PlayerPrefs.HasKey(ShopDataKeys.SelectedSkinKey)) return 0; 
            return PlayerPrefs.GetInt(ShopDataKeys.SelectedSkinKey);
        }

        public void AddNewSkin(int index)
        {
            foreach (var el in _purchasedSkins)
            {
                if (el == index)
                    return; 
            }
            
            _purchasedSkins.Add(index);
            int[] skins = _purchasedSkins.ToArray();
            PlayerPrefs_Pro.SaveArray(ShopDataKeys.PurchasedKey, skins);
        }

        private List<int> LoadSkins()
        {
            if (PlayerPrefs.HasKey(ShopDataKeys.PurchasedKey))
            {
                var list = new List<int>();
                list.Add(0);
                
                PlayerPrefs_Pro.SaveArray(ShopDataKeys.PurchasedKey, list.ToArray());
                return list; 
            }
            
            var skins = PlayerPrefs_Pro.LoadIntArray(ShopDataKeys.PurchasedKey);
            var transformed = new List<int>();
            
            foreach (var el in skins)
                transformed.Add(el);

            return transformed; 
        }

        public void Refresh()
        {
            _secondSkin = LoadSecondSkin();
            _purchasedSkins = LoadSkins(); 
        }
    }
}