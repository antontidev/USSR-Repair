using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time;

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < Time.deltaTime)
        {
            EndOfTime();
        }
    }
    void EndOfTime()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
