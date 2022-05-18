using System.Collections;
using System.Collections.Generic;
using Dreamteck.Splines;
using Lean.Common;
using UnityEngine;

public class PlayerController : LeanManualTranslate
{
    private Animator _animator;
    private SplineFollower _sf;
    [SerializeField] private GameObject playerCollider;

    private static readonly int IsStarted = Animator.StringToHash("isStarted");

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _sf = GetComponent<SplineFollower>();
    }

    public void ChangeMotion(Vector2 magnitude)
    {
        _sf.motion.offset += new Vector2((DirectionA * magnitude.x).x,(DirectionA * magnitude.x).y)*Time.deltaTime;
    }

    public void FollowEnable()
    {
        _sf.enabled = !_sf.enabled;//oyun baslangicinda spline follower aktif et
        playerCollider.SetActive(true);//lean hit collider oyun baslangicinda aktif et
    }
    // Update is called once per frame
    new void Update()
    {
        if (GameManager.instance.currentState==States.Playing)
        {
            _animator.SetBool(IsStarted,true);
        } 
    }
}
