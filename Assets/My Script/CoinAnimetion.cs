using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnimetion : MonoBehaviour
{
    [SerializeField] private GameObject gameObject;
    [SerializeField] private Vector3 _rotation; 
    
    void Update()
    {
        gameObject.transform.Rotate(_rotation*Time.deltaTime);
    }
    
}
