using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreMenu : MonoBehaviour
{
    public Text FinalScore;
    public Text FinalCountries;
    string Score;
    string Countries;

    private void Start()
    {
        Score = GameObject.Find("ScoreManager").GetComponent<Score>().score.ToString();
        Countries = GameObject.Find("ScoreManager").GetComponent<Score>().republicCount.ToString();

    }
    private void Update()
    {
        
        FinalScore.text = "Score: " + Score;
        FinalCountries.text = "Countries: " + Countries + "/14";
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
