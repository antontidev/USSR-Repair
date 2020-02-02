using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreMenu : MonoBehaviour
{
    public Text FinalScore;
    public Text FinalCountries;
    public void Start()
    {
        // string score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Score;
        // string countries = GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Countries;
       // FinalScore.text = "Score: " + score;
       // FinalCountries.text = "Countries: " + countries + "/14";
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
