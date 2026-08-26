using UnityEngine;

namespace VRKDEV.PlayerPrefsPro.InternalServices
{
    internal class BoolConvertor
    {
        public int BoolToInt(bool value)
        {
            int returnValue;
            if (value == true)
                returnValue = 1;
            else
                returnValue = -1;

            return returnValue;
        }

        public bool IntToBool(int value)
        { 
            bool returnValue;
            if (value == 1)
                returnValue = true; 
            else
                returnValue = false;

            return returnValue; 
        }
    }

    internal class BoolSaver 
    {
        private BoolConvertor _convertor = new BoolConvertor();

        public bool LoadBoolean(string key)
        {
            var valueToReturn = _convertor.IntToBool(PlayerPrefs.GetInt(key)); 
            return valueToReturn;
        }

        public void SaveBoolean(string key, bool value)
        {
            var valueToSave = _convertor.BoolToInt(value);
            PlayerPrefs.SetInt(key, valueToSave);
        }
    }
}
