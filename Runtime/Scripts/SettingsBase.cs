using UnityEngine;

namespace CleverCrow.Fluid.SimpleSettings {
    public abstract class SettingsBase<T>: SettingsObject where T : SettingsObject {
        private static T _current;

        private static string RESOURCE_PATH => typeof(T).Name;

        public static T Current {
            get {
                if (_current == null) {
                    var so = Resources.Load<T>(RESOURCE_PATH);
                    Debug.AssertFormat(so != null,
                        $"Could not load {RESOURCE_PATH}. Please verify a {RESOURCE_PATH} " +
                        $"object is available at `Resources/{RESOURCE_PATH}'. If not please create one.");

                    _current = Instantiate(so);
                    _current.Setup();
                }

                return _current;
            }

            set { _current = value; }
        }
    }
}
