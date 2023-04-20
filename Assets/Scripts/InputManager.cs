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

    //public Vector3 Direction => throw new System.NotImplementedException();

    private Vector3 direction = Vector3.zero;
    public Vector3 Direction { get { return direction; } }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = _Direction(UIManager.Instance.Joystick.Horizontal, UIManager.Instance.Joystick.Vertical);
        Debug.Log("direction = " + direction);
    }
    private Vector3 _Direction(float hozizontal, float vertical)
    {
        return new Vector3(hozizontal, 0, vertical);
    }
}
