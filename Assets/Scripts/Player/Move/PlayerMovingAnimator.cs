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
        var currentState = ChangeCurrentState(animRun);
        if (speed <= 0 && moveSpeed != 0 && moveSpeed > 0)
        {
            moveSpeed -= Time.deltaTime;
            animator.SetFloat(animMove, moveSpeed);
        }
        else
            if (speed > 0)
        {
            if (currentState == animRun)
            {
                animator.SetTrigger(animRun);
            }
            animator.SetFloat(animMove, speed);
            moveSpeed = speed;
        }
        else
            return;
    }

}
