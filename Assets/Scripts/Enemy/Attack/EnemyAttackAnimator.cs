using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackAnimator : EnemyAnimator
{
    void Update()
    {
        SetAnimator();
    }
    private void SetAnimator()
    {
        if (!enemyControl.IsAttack || enemyControl.EnemyFindPlayer.VisibleTargets == null || enemyControl.CurrentState == animAttack) return;
        animator.SetTrigger(animAttack);
        //if () return;
        enemyControl.SetCurrentState(animAttack);
    }
}
