using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public float score;
    public float secondsForStartSliv;

    public bool isUSSR;
    public float resourceDefault;
    public float resource;
    public void TakeDamage(float damage)
    {
        score += damage;
        if (isUSSR)
        {
            resource += damage;
        }
        else
        {
            resource -= damage;
        }
        if (resource <= 0)
        {

            isUSSR = true;
        }
    }

    public int multiplier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
