using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : NghiaMonoBehaviour
{
    [SerializeField]
    private float playerMoveSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movedirection = InputManager.Instance.Direction;
        if (movedirection.magnitude <= 0.1f) return;
        _Moving(movedirection);
    }
    private void _Moving(Vector3 direction)
    {
        transform.parent.position += direction * playerMoveSpeed * Time.deltaTime;
    }
    protected override void ResetValue()
    {
        base.ResetValue();
        playerMoveSpeed = 3;
    }
}
