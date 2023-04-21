using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovingAnimator : Anim
{
    const string animRun = "Run";
    const string animMove = "MoveSpeed";
    private float moveSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void _MovingAnimator(Animator playerAnimator, float speed)
    {
        if (speed <= 0 && moveSpeed != 0 && moveSpeed > 0)
        {
            moveSpeed -= Time.deltaTime;
            playerAnimator.SetFloat(animMove, moveSpeed);
        }
        else
            if (speed > 0)
        {
            if (ChangeCurrentState(animRun) == animRun)
            {
                playerAnimator.SetTrigger(animRun);
            }
            playerAnimator.SetFloat(animMove, speed);
            moveSpeed = speed;
        }
        else
            return;

    }

}
