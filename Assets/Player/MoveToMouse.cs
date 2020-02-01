using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(mousePosition);
        worldPoint.z = 0;
        transform.position = worldPoint;
        bool mouseDown = Input.GetMouseButtonDown(0);

        animator.SetBool("Love", mouseDown);
        if (mouseDown)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            bool love = Physics.Raycast(ray, out hit);
            animator.SetBool("Love", love);
            if (love)
            {
                if (hit.transform.gameObject.tag == "Republic")
                {
                    //something
                }
            }
        }
    }
}
