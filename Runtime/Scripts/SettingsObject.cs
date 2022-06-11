using UnityEngine;

namespace CleverCrow.Fluid.SimpleSettings {
    public class SettingsObject : ScriptableObject {
        public void Setup () {
            OnSetup();
        }

        protected virtual void OnSetup () {
        }
    }
}
