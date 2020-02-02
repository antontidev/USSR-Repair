using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choosing : MonoBehaviour
{
    private SpriteRenderer renderer;
    public float scaleEffect = 2f;
    private Vector3 localScaleOld;
    public Vector3 localScaleTarget;
    

    public bool entered = false;
    private void OnMouseEnter()
    {
        entered = true;
 
    }
    

    private void OnMouseExit()
    {
        entered = false;   
    }
    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        localScaleOld = transform.localScale;
        localScaleTarget = transform.localScale * 1.10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (entered)
        {
          
            transform.localScale = Vector3.Lerp(localScaleTarget, localScaleOld, scaleEffect * Time.deltaTime);
        }
        if (Vector3.Distance(localScaleTarget, localScaleOld) > 0.01f && !entered)
        {
            transform.localScale = Vector3.Lerp(localScaleOld, localScaleTarget, scaleEffect * Time.deltaTime); 
        }
    }
}
