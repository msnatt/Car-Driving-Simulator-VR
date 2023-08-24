using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAnimetion : MonoBehaviour
{
    [Header("Animetion Arrow")] 
    [SerializeField] private GameObject agameObject;
    [SerializeField] private float _max; 
    [SerializeField] private float _min;
    [SerializeField] private float speedarrow = 2.5f;
    private bool ishigh = true;
    [Header("Scale Arrow")] 
    [SerializeField] private Transform player;
    private float _DistanceToplayer;
    
    void Start()
    {
    }
    void Update()
    {
        if (agameObject.transform.position.y >= _min-1 && ishigh)
        {
            agameObject.transform.position =new Vector3(agameObject.transform.position.x,agameObject.transform.position.y+(Time.deltaTime*speedarrow),agameObject.transform.position.z);
            if (agameObject.transform.position.y > _max)
            {
                ishigh = false;
            }

        }
        else if (agameObject.transform.position.y <= _max+1 && !ishigh)
        {
            agameObject.transform.position =new Vector3(agameObject.transform.position.x,agameObject.transform.position.y-(Time.deltaTime*speedarrow),agameObject.transform.position.z);
            if (agameObject.transform.position.y < _min)
            {
                ishigh = true;
            }
        }
        _DistanceToplayer = Vector3.Distance(player.position,agameObject.transform.position);
        
        Vector3 newScale = new Vector3(_DistanceToplayer/20,_DistanceToplayer/20,_DistanceToplayer/20);
        agameObject.transform.localScale = newScale;

    }
    
}
