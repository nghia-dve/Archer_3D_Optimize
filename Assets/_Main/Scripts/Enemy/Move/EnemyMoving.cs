using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : Movement
{
    [SerializeField]
    private EnemyControl enemyControl;
    [SerializeField]
    private float EnemyMoveSpeed = 2;
    void Update()
    {
        var target = enemyControl.EnemyFindPlayer.VisibleTargets;
        var rangeAttack = enemyControl.RangeAttack;
        if (target == null || rangeAttack < 0) return;
        var direction = target.transform.position - transform.parent.position;
        LookAtTaget(enemyControl.Model, direction);
        if (direction.magnitude < rangeAttack || enemyControl.IsAttack) return;
        _Moving(transform.parent.gameObject, direction, EnemyMoveSpeed);
    }

    private void _Moving(GameObject gameObject, Vector3 direction, float speed)
    {
        gameObject.transform.position += direction.normalized * speed * Time.deltaTime;

    }
    #region Reset In Editor
    protected override void LoadComponent()
    {
        base.LoadComponent();
        enemyControl = GetComponentInParent<EnemyControl>();
    }
    protected override void ResetValue()
    {
        base.ResetValue();
        EnemyMoveSpeed = 2;
        rotationSpeed = 780;
    }
    #endregion
}
