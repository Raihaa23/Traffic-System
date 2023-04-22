using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public bool _isRedLight;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (_isRedLight)
        {
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        }
        
        else
        {
            transform.position = new Vector3(transform.position.x, 20, transform.position.z);
        }
    }
}
