using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovingAnimator : PalyerAnimator
{
    private float moveSpeed = 0;

    void Update()
    {
        if (playerControl.IsAttack || !playerControl.IsExitState) return;
        _MovingAnimator(playerControl.Moveddirection.magnitude);
    }
    private void _MovingAnimator(float speed)
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
    #region Reset In Editor
    protected override void LoadComponent()
    {
        base.LoadComponent();
    }
    #endregion 
}
