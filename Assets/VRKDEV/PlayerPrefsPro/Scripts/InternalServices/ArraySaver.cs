using System.Collections.Generic;
using UnityEngine;

namespace VRKDEV.PlayerPrefsPro.InternalServices
{
    public class ArraySaver
    {
        public void SaveArray(string key, int[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                PlayerPrefs.SetInt($"{key}_{i}", array[i]);
            }
            PlayerPrefs.SetInt($"{key}_lenght", array.Length); 
        }

        public void SaveArray(string key, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                PlayerPrefs.SetString($"{key}_{i}", array[i]);
            }
            PlayerPrefs.SetInt($"{key}_lenght", array.Length);
        }

        public void SaveArray(string key, float[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                PlayerPrefs.SetFloat($"{key}_{i}", array[i]);
            }
            PlayerPrefs.SetInt($"{key}_lenght", array.Length);
        }

        public void SaveBoolArray(string key, bool[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                PlayerPrefs_Pro.SaveBool($"{key}_{i}", array[i]);
            }
            PlayerPrefs.SetInt($"{key}_lenght", array.Length);
        }

        public void SaveVector2Array(string key, Vector2[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                PlayerPrefs_Pro.SaveVector2($"{key}_{i}", array[i]);
            }
            PlayerPrefs.SetInt($"{key}_lenght", array.Length);
        }

        public void SaveVector3Array(string key, Vector3[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                PlayerPrefs_Pro.SaveVector3($"{key}_{i}", array[i]);
            }
            PlayerPrefs.SetInt($"{key}_lenght", array.Length);
        }

        public void SaveColorArray(string key, Color[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                PlayerPrefs_Pro.SaveColor($"{key}_{i}", array[i]);
            }
            PlayerPrefs.SetInt($"{key}_lenght", array.Length);
        }

        public int[] LoadIntArray(string key)
        {
            int arrayLenght = PlayerPrefs.GetInt($"{key}_lenght");
            int[] array = new int[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                array[i] = PlayerPrefs.GetInt($"{key}_{i}"); 
            }

            return array;
        }

        public string[] LoadStringArray(string key)
        {
            int arrayLenght = PlayerPrefs.GetInt($"{key}_lenght");
            string[] array = new string[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                array[i] = PlayerPrefs.GetString($"{key}_{i}");
            }

            return array;
        }

        public float[] LoadFloatArray(string key)
        {
            int arrayLenght = PlayerPrefs.GetInt($"{key}_lenght");
            float[] array = new float[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                array[i] = PlayerPrefs.GetFloat($"{key}_{i}");
            }

            return array;
        }

        public bool[] LoadBoolArray(string key)
        {
            int arrayLenght = PlayerPrefs.GetInt($"{key}_lenght");
            bool[] array = new bool[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                array[i] = PlayerPrefs_Pro.LoadBool($"{key}_{i}");
            }

            return array;
        }

        public Vector2[] LoadVector2Array(string key)
        {
            int arrayLenght = PlayerPrefs.GetInt($"{key}_lenght");
            Vector2[] array = new Vector2[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                array[i] = PlayerPrefs_Pro.LoadVector2($"{key}_{i}");
            }

            return array;
        }

        public Vector3[] LoadVector3Array(string key)
        {
            int arrayLenght = PlayerPrefs.GetInt($"{key}_lenght");
            Vector3[] array = new Vector3[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                array[i] = PlayerPrefs_Pro.LoadVector3($"{key}_{i}");
            }

            return array;
        }

        public Color[] LoadColorArray(string key)
        {
            int arrayLenght = PlayerPrefs.GetInt($"{key}_lenght");
            Color[] array = new Color[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                array[i] = PlayerPrefs_Pro.LoadColor($"{key}_{i}");
            }

            return array;
        }
    }
}
