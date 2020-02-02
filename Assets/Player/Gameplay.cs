using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gameplay : MonoBehaviour
{
    private bool loosingStarted = false;
    public Animator animator;
    public bool isAnimation = false;

    public float score;
    private float timer = 5f;

    private float defaultTimer;

    public float defaultDamage = 40;

    public float damage;

    public bool isUSSR = false;
    private float resourceDefault;
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
            loosingStarted = true;
            resource = resourceDefault / 3;
        }
    }

    public void OnMouseDown()
    {
        TakeDamage(defaultDamage);
        isAnimation = true;
        if (loosingStarted)
        {
            timer = defaultTimer;
        }
        animator.SetBool("Click", true);
    }
    public void OnMouseUp()
    {
        isAnimation = false;
        animator.SetBool("Click", false);
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
            if (loosingStarted)
                timer -= Time.deltaTime;
        }
        else
        {
            loosingStarted = false;
        }
        animator.SetFloat("time", timer);
        animator.SetBool("isUssr", isUSSR);
    }
}
