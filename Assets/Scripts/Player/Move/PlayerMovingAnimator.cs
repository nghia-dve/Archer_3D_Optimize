using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovingAnimator : PalyerAnimator
{
    const string animRun = "Run";
    const string animMove = "MoveSpeed";
    private float moveSpeed = 0;
    public float MoveSpeed { get { return moveSpeed; } }
    [SerializeField]
    private PlayerControl playerControl;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void _MovingAnimator(float speed)
    {
        //var currentState =
        //ChangeCurrentState(animRun);
        //Debug.Log("currentState" + currentState);
        if (playerControl.CurrentState != animRun)
        {
            animator.SetTrigger(animRun);
            playerControl.SetCurrentState(animRun);
        }
        if (speed <= 0 && moveSpeed != 0 && moveSpeed > 0)
        {
            moveSpeed -= Time.deltaTime;
            animator.SetFloat(animMove, moveSpeed);
        }
        else
            if (speed > 0)
        {
            animator.SetFloat(animMove, speed);
            moveSpeed = speed;
        }
        else
            return;
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        playerControl = transform.parent.GetComponent<PlayerControl>();
    }

}
