using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;
using System.Text;
public class NameMenu : MonoBehaviour
{
    public InputField InputFieldName;
    public bool isLove = true;
    ToggleGroup toggle;
    public string name;

    private void Start()
    {
        toggle = GetComponent<ToggleGroup>();
    }
    private void Update()
    {
      //  if(LoveToggle.)
        
    }
    public void PlayGame()
    {
        name = InputFieldName.text;
        ConvertNameToEvent();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ConvertNameToEvent()
    {
        byte[] bytes = Encoding.Unicode.GetBytes(name);
        double max = 0;
        double summ = 0;
        Random rnd = new Random();
        foreach (int c in bytes)
        {
            if (c > max)
                max = c;
        }
        foreach(double c in bytes)
        {
            if (c < max)
                summ += c / (rnd.Range(1.0f, 3.0f) * max);
        }

    }
}
