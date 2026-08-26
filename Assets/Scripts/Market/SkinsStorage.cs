using UnityEngine;

namespace Market
{
    [CreateAssetMenu(menuName = "ScriptableObjects/SkinsStorage", fileName = "SkinsStorage")]
    public class SkinsStorage : ScriptableObject
    {
        public Skin[] skins; 
    }
}