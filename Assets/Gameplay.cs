using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gameplay : MonoBehaviour
{
    private SpriteRenderer renderer;
    public Material material;
    private Material defaultMaterial;
    public float score;
    private float secondsForStartSliv = 5f;

    private bool isUSSR;
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
            renderer.material = material;
            isUSSR = true;
        }
    }

    public void OnMouseDown()
    {
        
    }
    public int multiplier;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        defaultMaterial = renderer.material;
        resourceDefault = resource;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
