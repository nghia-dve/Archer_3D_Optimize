using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAnimator : Anim
{
    [SerializeField]
    protected EnemyControl enemyControl;
    protected const string animFly = "Fly";
    protected const string animAttack = "Attack";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    #region Reset In Editor
    protected override void LoadComponent()
    {
        base.LoadComponent();
        animator = transform.parent.GetComponent<Animator>();
        enemyControl = transform.parent.GetComponent<EnemyControl>();
    }
    #endregion
}
