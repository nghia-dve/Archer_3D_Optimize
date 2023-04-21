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
    }
    public void _Moving(GameObject player, Vector3 direction)
    {
        player.transform.position += direction * playerMoveSpeed * Time.deltaTime;
    }
    protected override void ResetValue()
    {
        base.ResetValue();
        playerMoveSpeed = 3;
    }
}
