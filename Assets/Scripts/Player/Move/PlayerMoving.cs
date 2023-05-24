using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : Movement
{
    [SerializeField]
    private float playerMoveSpeed = 3;
    public float PlayerMoveSpeed { get { return playerMoveSpeed; } }
    [SerializeField]
    private PlayerControl playerControl;

    void Update()
    {
        if (playerControl.IsAttack || !playerControl.IsExitState ||
            playerControl.Moveddirection.magnitude <= 0.1f) return;
        _Moving(transform.parent.gameObject, playerControl.Moveddirection, playerMoveSpeed);
    }
    private void _Moving(GameObject player, Vector3 direction, float speed)
    {
        player.transform.position += direction * speed * Time.deltaTime;
        LookAtTaget(player, direction);
    }

    #region reset in editor
    protected override void LoadComponent()
    {
        base.LoadComponent();
        playerControl = transform.parent.GetComponent<PlayerControl>();
    }
    protected override void ResetValue()
    {
        base.ResetValue();
        playerMoveSpeed = 3;
        rotationSpeed = 720;
    }
    #endregion
}
