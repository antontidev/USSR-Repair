using UnityEngine;
using UnityEngine.SceneManagement;

public class Info : MonoBehaviour
{
    public NameMenu nameMenu;
    public int currentEvent;
    void Awake()
    {
        DontDestroyOnLoad(gameObject.GetComponent<Info>());
       // SceneManager.sceneLoaded += OnSceneLoaded;
    }

   /* void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        if (scene.name == "MainMenu")
        {
            Destroy(gameObject);
        }
    }*/

    private void Start()
    {
        currentEvent = nameMenu.currentEvent;
    }
}
