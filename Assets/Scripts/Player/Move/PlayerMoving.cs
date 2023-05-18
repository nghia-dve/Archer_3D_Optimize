using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : NghiaMonoBehaviour
{
    [SerializeField]
    private float playerMoveSpeed = 3;
    [SerializeField]
    private float rotationSpeed = 720;
    [SerializeField]
    private PlayerControl playerControl;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void _Moving(GameObject player, Vector3 direction)
    {
        player.transform.position += direction * playerMoveSpeed * Time.deltaTime;
        LookAtTaget(direction);
    }
    private void LookAtTaget(Vector3 direction)
    {
        Quaternion toRatation = Quaternion.LookRotation(direction, Vector3.up);
        transform.parent.rotation = Quaternion.RotateTowards(transform.parent.rotation, toRatation, rotationSpeed * Time.deltaTime);
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
