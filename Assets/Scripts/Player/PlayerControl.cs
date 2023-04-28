using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControl : NghiaMonoBehaviour
{
    [SerializeField]
    private PlayerMoving playerMoving;
    [SerializeField]
    private PlayerMovingAnimator playerMovingAnimator;
    [SerializeField]
    private PlayerAttackSwordAnimator playerAttackSwordAnimator;
    [SerializeField]
    private PlayerChangeSkin playerChangeSkin;
    [SerializeField]
    private bool isExitState = true;
    public bool IsExitState { get { return isExitState; } }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movedirection = InputManager.Instance.Direction;
        bool isAttack = UIManager.Instance.ButtonNormalAttack.IsAttack;
        if (isAttack)
        {
            Debug.Log("attack");
            isExitState = false;
            movedirection = Vector3.zero;
            playerAttackSwordAnimator.AnimatorAttack();
            playerChangeSkin.ChangeModelWeapon(playerAttackSwordAnimator.AnimSingleTwohandSwordAttack, 1);
        }
        else
        if (isExitState)
        {
            Debug.Log("run");
            playerMovingAnimator._MovingAnimator(movedirection.magnitude);
            playerChangeSkin.ChangeModelWeapon(playerAttackSwordAnimator.AnimSingleTwohandSwordAttack, 0);
            if (movedirection.magnitude <= 0.1f) return;
            playerMoving._Moving(gameObject, movedirection);
        }
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        playerMoving = transform.Find("PlayerMoving").GetComponent<PlayerMoving>();
        playerMovingAnimator = transform.Find("PlayerMovingAnimator").GetComponent<PlayerMovingAnimator>();
        playerAttackSwordAnimator = transform.Find("PlayerAttackSwordAnimator").GetComponent<PlayerAttackSwordAnimator>();
        playerChangeSkin = transform.Find("PlayerChangeSkin").GetComponent<PlayerChangeSkin>();
    }
    #region even anim
    private void State()
    {
        if (UIManager.Instance.ButtonNormalAttack.IsAttack) return;
        isExitState = true;
    }
    #endregion
}
