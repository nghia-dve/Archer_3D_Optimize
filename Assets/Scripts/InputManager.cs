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

    private Vector3 direction = Vector3.zero;
    public Vector3 Direction { get { return direction; } }

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var horizontal = UIManager.Instance.UIGame.Joystick.Horizontal;
        var vertical = UIManager.Instance.UIGame.Joystick.Vertical;
        direction = _Direction(horizontal, vertical);
        //Debug.Log("direction = " + direction);
    }
    private Vector3 _Direction(float hozizontal, float vertical)
    {
        return new Vector3(hozizontal, 0, vertical);
    }
}
