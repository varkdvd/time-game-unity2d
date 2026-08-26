using System;
using Market;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class PlayerSkinAplyer : MonoBehaviour
    {
        [SerializeField] private SkinsStorage storage; 
        
        private SpriteRenderer _renderer;
        private ShopDataStorage _storage;
        
        private void Awake()
        {
            _renderer = GetComponent<SpriteRenderer>();
            _storage = new ShopDataStorage();

            _renderer.color = storage.skins[_storage.SecondSkin].skinColor;
        }
    }
}
