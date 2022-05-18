using System;
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

    private PlayerController _playerController;
    void Awake()
    {
        currentState = States.TapToStart;
        if (instance==null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _playerController= GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)&& currentState==States.TapToStart)
        {
            tapToStartText.SetActive(false);
            _playerController.FollowEnable();
            currentState = States.Playing;
        }
    }
}
