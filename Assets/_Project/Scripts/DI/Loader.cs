using Reflex.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    private void Start()
    {
        // If you are loading scenes without addressables
        var scene = SceneManager.LoadScene("Greet", new LoadSceneParameters(LoadSceneMode.Single));
        ReflexSceneManager.PreInstallScene(scene, builder => builder.AddSingleton("Beautiful"));
    }
}