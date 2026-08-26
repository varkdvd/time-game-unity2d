using UnityEngine;

namespace Player
{
    public class BoxColorSwitcher
    {
        public void ColorSprite(SpriteRenderer renderer)
        {
            var color = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                255f
            );

            renderer.color = color;
        }
    }
}
