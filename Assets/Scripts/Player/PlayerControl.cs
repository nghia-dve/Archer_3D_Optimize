using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : NghiaMonoBehaviour
{
    [SerializeField]
    private PlayerMoving playerMoving;
    [SerializeField]
    private Animator playerAnimator;
    [SerializeField]
    private PlayerMovingAnimator playerMovingAnimator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movedirection = InputManager.Instance.Direction;
        playerMovingAnimator._MovingAnimator(playerAnimator, movedirection.magnitude);
        if (movedirection.magnitude <= 0.1f) return;
        playerMoving._Moving(gameObject, movedirection);
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        playerMoving = transform.Find("PlayerMoving").GetComponent<PlayerMoving>();
        playerMovingAnimator = transform.Find("PlayerMovingAnimator").GetComponent<PlayerMovingAnimator>();
        playerAnimator = GetComponent<Animator>();
    }

}
