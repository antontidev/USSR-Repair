using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    public List<Gameplay> countries;
    public float score;
    public int republicCount;

    public Timer timer;
   
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Update()
    {
        if (timer.time < Time.deltaTime)
        {
            foreach (Gameplay gp in countries)
            {
                if (gp.isUSSR)
                    republicCount++;
                score += gp.score;
            }
        }
    }
}
