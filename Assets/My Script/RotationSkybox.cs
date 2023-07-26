using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSkybox : MonoBehaviour
{
    [SerializeField] private Material skybox;
    private float _elapsedTime = 0f;
    private float _timescale = 2.5f;
    private static readonly int Rotation = Shader.PropertyToID("_Rotation");

    void Update ()
    {
        _elapsedTime += Time.deltaTime;
        skybox.SetFloat(Rotation, _elapsedTime*_timescale);
    }
}
