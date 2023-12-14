using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFindPlayer : NghiaMonoBehaviour
{
    public float viewRadius;

    [Range(0, 360)]
    public float viewAngle;

    [SerializeField]
    private LayerMask targetMask;

    [SerializeField]
    private LayerMask obstacleMask;

    [SerializeField]
    private GameObject visibleTargets;
    public GameObject VisibleTargets { get { return visibleTargets; } }
    private void FixedUpdate()
    {
        if (visibleTargets == null)
        {
            FindVisibleTagets();
        }
    }
    public Vector3 DirFromAngle(float angleInDegrees, bool angleIsGlobal)
    {
        if (!angleIsGlobal)
        {
            angleInDegrees += transform.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }

    private void FindVisibleTagets()
    {
        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, viewRadius, targetMask);

        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
            Transform target = targetsInViewRadius[i].transform;
            Vector3 dirToTarget = (target.position + (Vector3.up * 0.5f) - transform.position).normalized;
            if (Vector3.Angle(transform.forward, dirToTarget) < viewAngle / 2)
            {
                float dstToTarget = Vector3.Distance(transform.position, target.position);
                if (!Physics.Raycast(transform.position, dirToTarget, dstToTarget, obstacleMask))
                {
                    visibleTargets = target.gameObject;
                }
            }
        }
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        viewRadius = 7;
        viewAngle = 300;
        targetMask = LayerMask.GetMask("Player");
        obstacleMask = LayerMask.GetMask("Obstacle");
    }
}
