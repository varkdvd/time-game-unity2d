using UnityEngine;

namespace VRKDEV.PlayerPrefsPro.InternalServices
{
    internal class VectorSaver
    {
        public void SaveVector2(Vector2 value, string key)
        {
            PlayerPrefs.SetFloat($"{key}_x", value.x);
            PlayerPrefs.SetFloat($"{key}_y", value.y);
        }

        public void SaveVector3(Vector3 value, string key)
        {
            PlayerPrefs.SetFloat($"{key}_x", value.x);
            PlayerPrefs.SetFloat($"{key}_y", value.y);
            PlayerPrefs.SetFloat($"{key}_z", value.z); 
        }

        public Vector2 LoadVector2(string key)
        {
            Vector2 returnValue = new Vector2();
            if (PlayerPrefs.HasKey($"{key}_x"))
            {
                returnValue.x = PlayerPrefs.GetFloat($"{key}_x");
                returnValue.y = PlayerPrefs.GetFloat($"{key}_y");
            }
            else
            {
                Debug.LogError($"KeyError: Vector2 with key '{key}' not was saved."); 
            }

            return returnValue;
        }

        public Vector3 LoadVector3(string key) 
        {
            Vector3 returnValue = new Vector3();
            if (PlayerPrefs.HasKey($"{key}_x"))
            {
                returnValue.x = PlayerPrefs.GetFloat($"{key}_x");
                returnValue.y = PlayerPrefs.GetFloat($"{key}_y");
                returnValue.z = PlayerPrefs.GetFloat($"{key}_z");
            }
            else
            {
                Debug.LogError($"KeyError: Vector3 with key '{key}' not was saved.");
            }

            return returnValue;
        }
    }
}
