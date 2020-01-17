using UnityEngine;

namespace CleverCrow.Fluid.SimpleSettings.Examples {
    [CreateAssetMenu(fileName = "ExampleSettings", menuName = "Fluid/Example Settings")]
    public class ExampleSettings : SettingsBase<ExampleSettings> {
        public bool myBool;
    }
}
