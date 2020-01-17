using UnityEngine;

namespace CleverCrow.Fluid.SimpleSettings.Examples {
    public class ExampleSettingsUsage : MonoBehaviour {
        private void Start () {
            Debug.Log($"Initial example settings value: {ExampleSettings.Current.myBool}");

            Debug.Log($"Changed value to false");
            ExampleSettings.Current.myBool = false;
        }
    }
}
