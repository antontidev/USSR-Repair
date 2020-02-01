using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text;
public class NameMenu : MonoBehaviour
{
    public GameObject prefab;
    public InputField InputFieldName;
    double summ = 0;
    public int currentEvent;
    private void Update()
    {
        
    }
    public void PlayGame()
    {
        name = InputFieldName.text;
        ConvertNameToEvent();
        if (summ > 0.001f && summ < 0.201f) currentEvent = 0;
        else if (summ > 0.201f && summ < 0.401f) currentEvent = 1;
            else if (summ > 0.401f && summ < 0.601f) currentEvent = 2;
                else if (summ > 0.601f && summ < 0.801f) currentEvent = 3;
                    else currentEvent = 4;
        
        GameObject info = Instantiate(prefab);
        info.GetComponent<Info>().nameMenu = this;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ConvertNameToEvent()
    {
        byte[] bytes = Encoding.Unicode.GetBytes(name);
        double max = 0;
        foreach (int c in bytes)
        {
            if (c > max)
                max = c;
        }
        foreach(double c in bytes)
        {
            if (c < max)
                summ += c / (Random.Range(1.0f, 4.0f) * max);
        }
    }
}
