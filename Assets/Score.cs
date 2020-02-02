using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    public List<Gameplay> countries;
    public float score = 0;
    public int republicCount = 0;
    public Timer timer;
    public Text Score_;
    public Text Countries_;
   
    private void Awake()
    {
        DontDestroyOnLoad(gameObject.GetComponent<Score>());
    }

    private void Update()
    {
        CheckScore();
        Countries_.text = "Countries: " + republicCount.ToString() + "/14";
        Score_.text = "Score: " + score.ToString();
    }
    public void CheckScore()
    {
        score = 0;
        republicCount = 0;
        foreach (Gameplay gp in countries)
        {
            if (gp.isUSSR)
            {
                republicCount++;
                
            }
                
            score += gp.score;
            
        }
    }
}
