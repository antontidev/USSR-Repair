using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    public Score score;
    public Text text;

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < Time.deltaTime)
        {
            EndOfTime();
        }

        text.text = "Time: " + Mathf.Round(time).ToString();
    }
    void EndOfTime()
    {
        score.CheckScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
