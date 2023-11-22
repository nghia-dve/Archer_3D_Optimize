using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackSwordAnimator : PalyerAnimator
{
    void Update()
    {
        if (!playerControl.IsAttack || animator.GetBool("IsAttack")) return;
        _AnimatorAttack();

    }
    private void _AnimatorAttack()
    {
        animator.SetBool("IsAttack", true);
    }
}
