﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class NameMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
