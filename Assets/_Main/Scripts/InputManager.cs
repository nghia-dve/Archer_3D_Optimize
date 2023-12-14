using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : NghiaMonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<InputManager>();
            return instance;
        }
    }
    [SerializeField]
    private Camera camera;
    private Vector3 direction = Vector3.zero;
    public Vector3 Direction { get { return direction; } }
    static readonly string Horizontal = "Horizontal";
    static readonly string Vertical = "Vertical";

    void FixedUpdate()
    {
#if UNITY_STANDALONE_WIN
        GetDirKeyBoard();
#elif UNITY_ANDROID
        GetJoystick();
#endif
    }
    /// <summary>
    /// Android
    /// </summary>
    private void GetDirJoystick()
    {
        float horizontal = UIManager.Instance.UIGame.Joystick.Horizontal;
        float vertical = UIManager.Instance.UIGame.Joystick.Vertical;
        Vector3 forward = camera.transform.forward;
        Vector3 right = camera.transform.right;
        forward.y = 0;
        right.y = 0;
        forward = forward.normalized;
        right = right.normalized;
        direction = vertical * forward + horizontal * right;
    }

    /// <summary>
    /// Window
    /// </summary>
    private void GetDirKeyBoard()
    {
        float horizontal = Input.GetAxis(Horizontal);
        float vertical = Input.GetAxis(Vertical);
        Vector3 forward = camera.transform.forward;
        Vector3 right = camera.transform.right;
        forward.y = 0;
        right.y = 0;
        forward = forward.normalized;
        right = right.normalized;
        direction = vertical * forward + horizontal * right;
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        camera = Camera.main;
    }
}
