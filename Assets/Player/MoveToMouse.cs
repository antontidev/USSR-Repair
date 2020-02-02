using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(mousePosition);
        worldPoint.z = 0;
        transform.position = worldPoint;

        bool love = false;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "Republic")
                {
                    love = true;
                }
            }
        }
    }
}
