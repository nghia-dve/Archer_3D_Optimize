using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackSwordAnimator : PalyerAnimator
{
    private const string animSingleTwohandSwordAttack = "Sword_L";
    public string AnimSingleTwohandSwordAttack { get { return animSingleTwohandSwordAttack; } }
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
    public void AnimatorAttack()
    {
        //var currentState =
        //ChangeCurrentState(animSingleTwohandSwordAttack);
        if (playerControl.CurrentState != animSingleTwohandSwordAttack)
        {
            animator.SetTrigger(animSingleTwohandSwordAttack);
            playerControl.SetCurrentState(AnimSingleTwohandSwordAttack);
        }

    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        playerControl = transform.parent.GetComponent<PlayerControl>();
    }
}
