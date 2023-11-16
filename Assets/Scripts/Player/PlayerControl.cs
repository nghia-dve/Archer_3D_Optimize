using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControl : NghiaMonoBehaviour
{
    [Header("Scripts")]
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


    [Header("===========================")]
    [SerializeField]
    private bool isExitState = true;
    public bool IsExitState { get { return isExitState; } }
    [SerializeField]
    protected string currentState;
    public string CurrentState { get { return currentState; } }
    [SerializeField]
    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return rigidbody; } }
    [SerializeField]
    private float hpPlayer;
    public float HpPlayer { get { return hpPlayer; } }
    [SerializeField]
    private int maxHpPlayer;
    public int MaxHpPlayer { get { return maxHpPlayer; } }


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
        isAttack = UIManager.Instance.UIGame.ButtonNormalAttack.IsAttack;
        if (!isAttack) return;
        isExitState = false;

    }
    private void FixedUpdate()
    {
        RemovePhysical();
    }
    private void RemovePhysical()
    {
        if (rigidbody.velocity == Vector3.zero) return;
        rigidbody.velocity = Vector3.zero;
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
    protected override void ResetValue()
    {
        base.ResetValue();
        hpPlayer = maxHpPlayer = 100;
    }
    #endregion
    #region even anim
    public void State()
    {
        if (UIManager.Instance.UIGame.ButtonNormalAttack.IsAttack) return;
        isExitState = true;
    }
    #endregion
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        #region test
        //if (other.name == "Fireball")
        //{
        //    var enemyControl = other.transform.parent.parent.parent.GetComponent<EnemyControl>();
        //    if (enemyControl.IsAttack)
        //    {
        //        hpPlayer--;
        //    }
        //}
        #endregion
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"OnCollisionEnter = {collision.gameObject.tag}");
        if (collision.gameObject.tag == "Fireball")
        {
            hpPlayer--;
        }
    }
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(other.name);
        if (other.gameObject.tag == "Fireball")
        {
            hpPlayer--;
        }
    }
}
