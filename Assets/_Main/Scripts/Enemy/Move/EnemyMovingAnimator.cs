using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovingAnimator : EnemyAnimator
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetAnimator();
    }
    private void SetAnimator()
    {
        if (enemyControl.IsAttack || enemyControl.EnemyFindPlayer.VisibleTargets == null || enemyControl.CurrentState == animFly) return;


        animator.SetTrigger(animFly);
        enemyControl.SetCurrentState(animFly);

    }
}
