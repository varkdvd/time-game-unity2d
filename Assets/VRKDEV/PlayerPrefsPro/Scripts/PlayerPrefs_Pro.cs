using System.Numerics;
using VRKDEV.PlayerPrefsPro.InternalServices;

namespace VRKDEV.PlayerPrefsPro
{
    public static class PlayerPrefs_Pro
    {
        private static BoolSaver _boolSaver = new BoolSaver();
        private static VectorSaver _vectorSaver = new VectorSaver();

        private static ColorSaver _colorSaver = new ColorSaver();
        private static ArraySaver _arraySaver = new ArraySaver();

        public static void SaveBool(string key, bool value) =>
            _boolSaver.SaveBoolean(key, value);

        public static void SaveVector2(string key, UnityEngine.Vector2 vector) =>
            _vectorSaver.SaveVector2(vector, key);

        public static void SaveVector3(string key, UnityEngine.Vector3 vector) =>
            _vectorSaver.SaveVector3(vector, key);

        public static void SaveColor(string key, UnityEngine.Color value) => 
            _colorSaver.SaveColor(key, value);

        public static void SaveArray(string key, int[] array) =>
            _arraySaver.SaveArray(key, array);

        public static void SaveArray(string key, float[] array) =>
            _arraySaver.SaveArray(key, array);

        public static void SaveArray(string key, string[] array) =>
            _arraySaver.SaveArray(key, array);

        public static void SaveArray(string key, bool[] array) =>
            _arraySaver.SaveBoolArray(key, array);

        public static void SaveArray(string key, UnityEngine.Vector2[] array) =>
            _arraySaver.SaveVector2Array(key, array);

        public static void SaveArray(string key, UnityEngine.Vector3[] array) =>
            _arraySaver.SaveVector3Array(key, array);

        public static void SaveArray(string key, UnityEngine.Color[] array) =>
            _arraySaver.SaveColorArray(key, array);


        public static bool LoadBool(string key)
        { 
            return _boolSaver.LoadBoolean(key);
        }

        public static UnityEngine.Vector2 LoadVector2(string key) 
        {
            return _vectorSaver.LoadVector2(key);
        }

        public static UnityEngine.Vector3 LoadVector3(string key)
        {
            return _vectorSaver.LoadVector3(key);
        }

        public static UnityEngine.Color LoadColor(string key)
        {
            return _colorSaver.LoadColor(key);
        }

        public static int[] LoadIntArray(string key)
        {
            return _arraySaver.LoadIntArray(key);
        }

        public static float[] LoadFloatArray(string key)
        {
            return _arraySaver.LoadFloatArray(key);
        }

        public static string[] LoadStringArray(string key)
        {
            return _arraySaver.LoadStringArray(key);
        }

        public static bool[] LoadBoolArray(string key)
        {
            return _arraySaver.LoadBoolArray(key);
        }

        public static UnityEngine.Vector2[] LoadVector2Array(string key)
        {
            return _arraySaver.LoadVector2Array(key);
        }

        public static UnityEngine.Vector3[] LoadVector3Array(string key)
        {
            return _arraySaver.LoadVector3Array(key);
        }

        public static UnityEngine.Color[] LoadColorArray(string key)
        {
            return _arraySaver.LoadColorArray(key);
        }
    }
}
