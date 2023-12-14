using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovingAnimator : PalyerAnimator
{
    private float moveSpeed = 0;

    void Update()
    {
        if (animator.GetBool("IsAttack") && moveSpeed != 0)
        {
            moveSpeed = 0;
            animator.SetFloat(animMove, moveSpeed);
        }
        if (playerControl.IsAttack || !playerControl.IsExitState) return;
        MovingAnimator(playerControl.Moveddirection.magnitude);
    }
    private void MovingAnimator(float speed)
    {

        animator.SetBool("IsAttack", false);
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
