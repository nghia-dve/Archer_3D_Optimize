using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : NghiaMonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<UIManager>();
            return instance;
        }
    }

    [Header("==MainUI==")]
    [SerializeField]
    private FloatingJoystick joyStick;
    [SerializeField]
    private UIMainButtonNormalAttack buttonNormalAttack;
    public UIMainButtonNormalAttack ButtonNormalAttack { get { return buttonNormalAttack; } }
    public FloatingJoystick Joystick { get { return joyStick; } }

    protected override void LoadComponent()
    {
        joyStick = GameObject.Find("Joystick Move").GetComponent<FloatingJoystick>();
        buttonNormalAttack = GameObject.Find("UIMainButtonNormalAttack").GetComponent<UIMainButtonNormalAttack>();
    }
}
