using UnityEngine;

namespace VRKDEV.PlayerPrefsPro.InternalServices
{
    public class ColorSaver
    {
        public void SaveColor(string key, Color value)
        {
            PlayerPrefs.SetFloat($"{key}_red", value.r);
            PlayerPrefs.SetFloat($"{key}_green", value.g);

            PlayerPrefs.SetFloat($"{key}_blin", value.b);
            PlayerPrefs.SetFloat($"{key}_alpha", value.a); 
        }

        public Color LoadColor(string key)
        {
            Color returnColor = Color.white;
            if (PlayerPrefs.HasKey($"{key}_red"))
            {
                returnColor.r = PlayerPrefs.GetFloat($"{key}_red");
                returnColor.g = PlayerPrefs.GetFloat($"{key}_green");

                returnColor.b = PlayerPrefs.GetFloat($"{key}_blin");
                returnColor.a = PlayerPrefs.GetFloat($"{key}_alpha");
            }
            else
            {
                Debug.LogError($"KeyError: Color with key '{key}' not was saved."); 
            }

            return returnColor;
        }
    }
}
