using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public NameMenu nameMenu;
    public int currentEvent;
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Start()
    {
        currentEvent = nameMenu.currentEvent;
    }
}
