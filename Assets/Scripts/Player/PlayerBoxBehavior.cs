using UnityEngine;
using Random = UnityEngine.Random;
using Timer = GameManagment.Timer;
using GameManagment.Score; 

namespace Player
{
    public class PlayerBoxBehavior : MonoBehaviour
    {
        [Header("Transform config")] [SerializeField]
        private float xOffset;

        [SerializeField] private float yOffset;

        [SerializeField] private float minScale;
        [SerializeField] private float maxScale;

        private SpriteRenderer _renderer;
        private Transform _transform;

        private void Awake()
        {
            _transform = transform;
            _renderer = GetComponent<SpriteRenderer>();
        }

        private void OnMouseDown()
        {
            _transform.position = new Vector3(Random.Range(-xOffset, xOffset), Random.Range(-yOffset, yOffset));
            Rescale();

            ScoreHolder.AddScore();
            Timer.OnResetTime?.Invoke();
        }

        private void Rescale()
        {
            var scale = _transform.localScale;
            var value = Random.Range(minScale, maxScale);

            scale.x = value;
            scale.y = value;
            _transform.localScale = scale;
        }
    }
}
