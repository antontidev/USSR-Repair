using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gameplay : MonoBehaviour
{
    private bool loosingStarted = false;
    public Animator animator;

    public float score;
    private float timer = 5f;
    private float secondTimer = 5f;

    private bool letsSmoke = false;

    private float defaultTimer;

    public float defaultDamage = 40;

    public float damage;
    private bool clicked = false;
    public bool isUSSR = false;
    private float resourceDefault;
    public float resource;

    public bool secondChance;
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
            loosingStarted = true;
            resource = resourceDefault / 3;
        }
    }

    public void OnMouseDown()
    {
        TakeDamage(defaultDamage);
        if (loosingStarted)
        {
            timer = defaultTimer;
        }
        if (secondChance)
        {
            clicked = true;
        }
        animator.SetBool("Click", true);

    }
    public void OnMouseUp()
    {
        animator.SetBool("Click", false);
        if (secondChance)
            clicked = false;
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        defaultTimer = timer;
        
        if (damage <= 0.01)
        {
            damage = defaultDamage;
        }
    }

    void Update()
    {
        if (isUSSR)
        {
            timer -= Time.deltaTime;
        }
        if (!secondChance && timer <= 0)
        {
            secondChance = true;
            timer = defaultTimer;
        }
        else if (secondChance && timer < 0)
        {
            animator.SetFloat("Time", timer);
            
            timer = defaultTimer;
            secondChance = false;
        }
        if (!secondChance)  
            animator.SetFloat("Time", timer);
        animator.SetBool("isUssr", isUSSR);
        animator.SetBool("Clicked", clicked);
    }
}
