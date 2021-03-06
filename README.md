# Simple Settings

A micro-framework for creating ScriptableObject settings files that automatically create an automatic copy when initialized. Useful for settings, one time setup, object references and more. Only meant for runtime usage.

## Quickstart

Simply create a settings file and add your data fields after installing the [package](#installation). Please note that under the hood this is just a simple `ScriptableObject` with a light wrapper.

```c#
[CreateAssetMenu(fileName = "ExampleSettings", menuName = "Fluid/Example Settings")]
public class ExampleSettings : SettingsBase<ExampleSettings> {
    public bool myBool;
}
```

Now generate your settings menu from the project window and place it in the root of any `Resources` folder. Note the name of the file must match the `*.cs` file.
 
When called at runtime a new instance will automatically be generated of the settings file if it doesn't already exist.

```c#
public class ExampleSettingsUsage : MonoBehaviour {
    private void Start () {
        Debug.Log($"Initial example settings value: {ExampleSettings.Current.myBool}");
    }
}
```

Full working example can be found by cloning this repo and opening `Assets/Example/Example.unity`.

## Installation

Simple Settings is used through [Unity's Package Manager](https://docs.unity3d.com/Manual/CustomPackages.html). In order to use it you'll need to add the following lines to your `Packages/manifest.json` file. After that you'll be able to visually control what specific version of Simple Settings you're using from the package manager window in Unity. This has to be done so your Unity editor can connect to NPM's package registry.

```json
{
  "scopedRegistries": [
    {
      "name": "NPM",
      "url": "https://registry.npmjs.org",
      "scopes": [
        "com.fluid"
      ]
    }
  ],
  "dependencies": {
    "com.fluid.simple-settings": "1.0.0"
  }
}
```

## Releases

Archives of specific versions and release notes are available on the [releases page](https://github.com/ashblue/unity-simple-settings/releases).

## Nightly Builds

To access nightly builds of the `develop` branch that are package manager friendly, you'll need to manually edit your `Packages/manifest.json` as so. 

```json
{
    "dependencies": {
      "com.fluid.simple-settings": "https://github.com/ashblue/unity-simple-settings.git#nightly"
    }
}
```

Note that to get a newer nightly build you must delete this line and any related lock data in the manifest, let Unity rebuild, then add it back. As Unity locks the commit hash for Git urls as packages.

## Development Environment

If you wish to run to run the development environment you'll need to install the latest [node.js](https://nodejs.org/en/). Then run the following from the root once.

`npm install`

If you wish to create a build run `npm run build` from the root and it will populate the `dist` folder.

### Making Commits

All commits should be made using [Commitizen](https://github.com/commitizen/cz-cli) (which is automatically installed when running `npm install`). Commits are automatically compiled to version numbers on release so this is very important. PRs that don't have Commitizen based commits will be rejected.

To make a commit type the following into a terminal from the root

```bash
npm run commit
```

---

This project was generated with [Oyster Package Generator](https://github.com/ashblue/oyster-package-generator).
