using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choosing : MonoBehaviour
{
    public float scaleEffect;
    public Transform transform;

    public bool entered = false;
    private void OnMouseEnter()
    {
        entered = true;
    }

    private void OnMouseExit()
    {
        entered = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
