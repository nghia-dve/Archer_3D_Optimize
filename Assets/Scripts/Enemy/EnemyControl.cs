using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : NghiaMonoBehaviour
{
    [SerializeField]
    private EnemyFindPlayer enemyFindPlayer;
    public EnemyFindPlayer EnemyFindPlayer { get { return enemyFindPlayer; } }
    [SerializeField]
    private float rangeAttack;
    public float RangeAttack { get { return rangeAttack; } }
    [SerializeField]
    private bool isAttack;
    public bool IsAttack { get { return isAttack; } }
    [SerializeField]
    protected string currentState;
    public string CurrentState { get { return currentState; } }
    [SerializeField]
    private float timeCheck = 1;
    //[SerializeField]
    //private bool isMeleeDamsge;
    //public bool IsMeleeDamsge { get { return isMeleeDamsge; } }
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        SetAttack();
        Debug.Log(currentState);

    }

    private void SetAttack()
    {
        var target = enemyFindPlayer.VisibleTargets;
        if (target == null) return;
        var direction = target.transform.position - transform.position;
        if (direction.magnitude < rangeAttack)
        {
            timeCheck -= Time.deltaTime;
            if (timeCheck > 0) return;
            timeCheck = 1;
            isAttack = true;
        }
        else
        {
            isAttack = false;
        }
    }
    public void SetCurrentState(string newCurrentState)
    {
        currentState = newCurrentState;
    }

    #region Rseset In Editor
    protected override void LoadComponent()
    {
        base.LoadComponent();
        enemyFindPlayer = GetComponentInChildren<EnemyFindPlayer>();
    }
    protected override void ResetValue()
    {
        base.ResetValue();
        var meleeDamsge = transform.Find("MeleeDamsge");
        var elementalDamsge = transform.Find("ElementalDamsge");
        if (meleeDamsge == null && elementalDamsge == null)
        {
            Debug.LogError("null meleeDamsge and elementalDamsge");
            rangeAttack = -999;
        }
        else
        if (meleeDamsge == null && elementalDamsge != null)
        {
            rangeAttack = 4f;
        }
        else
        if (meleeDamsge != null && elementalDamsge == null)
        {
            rangeAttack = 1.5f;
        }
        else
        {
            Debug.LogWarning("check again meleeDamsge and elementalDamsge");
            rangeAttack = -999;

        }
    }
    #endregion
}
