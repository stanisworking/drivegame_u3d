using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    public TMP_Text loadingText;

    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadSceneAsync(string sceneName) {
        StartCoroutine(LoadSceneCoroutine(sceneName));
    }

    IEnumerator LoadSceneCoroutine(string sceneName)
    {
        // Begin loading the scene
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        // Optional: prevent the scene from activating immediately
        // operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            // Unity loads up to 0.9 before activation
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            loadingText.text = "" + (100*progress) + " %";

            // Optionally wait here for input or animation before activating scene
            // if (progress >= 1f) operation.allowSceneActivation = true;

            yield return null;
        }
    }

    public void SetTimeScale(float scale) {
        Time.timeScale = scale;
    }
}
