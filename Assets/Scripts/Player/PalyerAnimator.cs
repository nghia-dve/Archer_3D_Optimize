using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PalyerAnimator : Anim
{
    [SerializeField]
    protected PlayerControl playerControl;
    protected const string animRun = "Run";
    protected const string animMove = "MoveSpeed";
    protected const string animSingleTwohandSwordAttack = "Sword_L";
    public string AnimSingleTwohandSwordAttack { get { return animSingleTwohandSwordAttack; } }
    #region Reset In Editor
    protected override void LoadComponent()
    {
        base.LoadComponent();
        animator = transform.parent.GetComponent<Animator>();
        playerControl = transform.parent.GetComponent<PlayerControl>();
    }
    #endregion
}
