using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControl : NghiaMonoBehaviour
{
    [SerializeField]
    private PlayerMoving playerMoving;
    public PlayerMoving PlayerMoving { get { return playerMoving; } }
    [SerializeField]
    private PlayerMovingAnimator playerMovingAnimator;
    [SerializeField]
    private PlayerAttackSwordAnimator playerAttackSwordAnimator;
    public PlayerAttackSwordAnimator PlayerAttackSwordAnimator { get { return playerAttackSwordAnimator; } }
    [SerializeField]
    private PlayerChangeSkin playerChangeSkin;
    [SerializeField]
    private bool isExitState = true;
    public bool IsExitState { get { return isExitState; } }

    [SerializeField]
    protected string currentState;
    public string CurrentState { get { return currentState; } }

    [SerializeField]
    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return rigidbody; } }

    private Vector3 moveddirection;
    public Vector3 Moveddirection { get { return moveddirection; } }

    private bool isAttack;
    public bool IsAttack { get { return isAttack; } }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveddirection = InputManager.Instance.Direction;
        isAttack = UIManager.Instance.ButtonNormalAttack.IsAttack;
        if (!isAttack) return;
        isExitState = false;

    }
    public void SetCurrentState(string newCurrentState)
    {
        currentState = newCurrentState;
    }
    #region reset editor
    protected override void LoadComponent()
    {
        base.LoadComponent();
        playerMoving = transform.Find("PlayerMoving").GetComponent<PlayerMoving>();
        playerMovingAnimator = transform.Find("PlayerMovingAnimator").GetComponent<PlayerMovingAnimator>();
        playerAttackSwordAnimator = transform.Find("PlayerAttackSwordAnimator").GetComponent<PlayerAttackSwordAnimator>();
        playerChangeSkin = transform.Find("PlayerChangeSkin").GetComponent<PlayerChangeSkin>();
        rigidbody = GetComponent<Rigidbody>();
    }
    #endregion
    #region even anim
    public void State()
    {
        if (UIManager.Instance.ButtonNormalAttack.IsAttack) return;
        isExitState = true;
    }
    #endregion
}
