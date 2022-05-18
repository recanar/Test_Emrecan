using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator _animator;

    private static readonly int IsStarted = Animator.StringToHash("isStarted");

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.currentState==States.Playing)
        {
            _animator.SetBool(IsStarted,true);
            transform.Translate(Vector3.forward * (Time.deltaTime * 5f));
        } 
    }
}
