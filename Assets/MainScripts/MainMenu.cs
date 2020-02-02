using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Vector3 point;
    private RectTransform trans;
    public float speed = 4;
    private void Start()
    {
        trans = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (Vector3.Distance(trans.localPosition, point) >= 0.01)
        {
            trans.localPosition = Vector3.Lerp(trans.localPosition, point, speed * Time.deltaTime);
        }
    }
    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
