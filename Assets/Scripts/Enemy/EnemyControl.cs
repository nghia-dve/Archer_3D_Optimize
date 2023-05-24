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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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

    }
    #endregion
}
