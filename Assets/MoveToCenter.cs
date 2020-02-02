using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCenter : MonoBehaviour
{
    public Vector3 point = new Vector3(3.04f, 0f, 0f);
    public float speed;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(point, transform.position) > 1f)
           transform.position = Vector3.Lerp(transform.position, point, speed * Time.deltaTime);
    }
}
