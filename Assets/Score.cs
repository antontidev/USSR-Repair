using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    public List<Gameplay> countries;
    public float score;
    public float time;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        foreach (Gameplay gp in countries)
        {
            score += gp.score;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
