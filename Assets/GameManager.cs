using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum States
{
    TapToStart,
    Playing,
    //Win,
    //Lose
}
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tapToStartText;
    public States currentState;
    public static GameManager instance;
    void Awake()
    {
        currentState = States.TapToStart;
        if (instance==null)
        {
            instance = this;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)&& currentState==States.TapToStart)
        {
            tapToStartText.SetActive(false);
            currentState = States.Playing;
        }
    }
}
