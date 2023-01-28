using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScene : MonoBehaviour
{
    public bool FadeOnStart = true;
    public float fadeDuration = 2;
    public Color fadeColor;
    private Renderer rend;
    public GameObject fadeScene;

    
    void Start()
    {
        rend = GetComponent<Renderer>();
        if(FadeOnStart)
            FadeIn();
    }


    public void FadeIn()
    {
        Fade(1, 0);
    }
    public void FadeOut()
    {
        fadeScene.SetActive(true);
        Debug.Log("Wait 2 second FadeOut");
        Fade(0, 1);
        
        new WaitForSeconds(fadeDuration);
        Debug.Log("Wait Completed");
        fadeScene.SetActive(false);
    }


    public void Fade(float alphaIn, float alphaOut)
    {
        StartCoroutine(FadeRoutine(alphaIn,alphaOut));
    }

    public IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {
        float timer = 0;
        while (timer <= fadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer/fadeDuration);

            rend.material.SetColor("_Color", newColor);

            timer += Time.deltaTime;
            yield return null;
        }

        Color newColor2 = fadeColor;
        newColor2.a = alphaOut;
        rend.material.SetColor("_Color", newColor2);

        

    }

}
