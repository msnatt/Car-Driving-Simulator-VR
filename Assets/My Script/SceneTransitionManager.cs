using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{   
    public FadeScene fadeScene;
    public void GoToScene(int sceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(sceneIndex));
    }

    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        fadeScene.FadeOut();
        yield return new WaitForSeconds(fadeScene.fadeDuration);

        // Launch The New Scene
        SceneManager.LoadScene(sceneIndex);
    }
}
