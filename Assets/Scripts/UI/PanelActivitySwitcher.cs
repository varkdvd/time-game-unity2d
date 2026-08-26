using UnityEngine;

namespace UI
{
    public class PanelActivitySwitcher : MonoBehaviour
    {
        public void SwitchActivity(bool value)
        {
            gameObject.SetActive(value);
        }
    }
}
