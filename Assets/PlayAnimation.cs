using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animator animator;
    private Score score;

    private void Start()
    {
        score = GetComponent<Score>();
    }
    // Update is called once per frame
    void Update()
    {

        foreach (Gameplay obj in score.countries)
        {
            if (obj.isAnimation)
                animator.SetBool("Love", obj.isAnimation); 
        }
    }
}
