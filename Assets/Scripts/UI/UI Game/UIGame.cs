using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGame : NghiaMonoBehaviour
{
    [Header("==MainUI==")]
    [SerializeField]
    private FloatingJoystick joyStick;
    public FloatingJoystick Joystick { get { return joyStick; } }
    [SerializeField]
    private UIMainButtonNormalAttack buttonNormalAttack;
    public UIMainButtonNormalAttack ButtonNormalAttack { get { return buttonNormalAttack; } }
    [SerializeField]
    private UIUserInfo userInfo;
    public UIUserInfo UserInfo { get { return userInfo; } }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    #region Reset In Editor
    protected override void LoadComponent()
    {
        joyStick = transform.Find("Joystick Move").GetComponent<FloatingJoystick>();
        buttonNormalAttack = GetComponentInChildren<UIMainButtonNormalAttack>();
        userInfo = GetComponentInChildren<UIUserInfo>();
    }

    #endregion
}
