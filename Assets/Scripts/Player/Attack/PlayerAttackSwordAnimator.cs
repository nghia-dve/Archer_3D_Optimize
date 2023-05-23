using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackSwordAnimator : PalyerAnimator
{
    void Update()
    {
        if (!playerControl.IsAttack) return;
        _AnimatorAttack();

    }
    private void _AnimatorAttack()
    {
        //var currentState =
        //ChangeCurrentState(animSingleTwohandSwordAttack);
        if (playerControl.CurrentState != animSingleTwohandSwordAttack)
        {
            animator.SetTrigger(animSingleTwohandSwordAttack);
            playerControl.SetCurrentState(AnimSingleTwohandSwordAttack);
        }

    }
}
