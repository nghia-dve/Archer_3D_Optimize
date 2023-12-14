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
    [SerializeField]
    private UIGame uIGame;
    public UIGame UIGame { get { return uIGame; } }


    [Header("=============")]
    [SerializeField]
    private PlayerControl playerControl;
    public PlayerControl PlayerControl { get { return playerControl; } }


    #region Reset In Editor
    protected override void LoadComponent()
    {
        playerControl = GameObject.Find("Player").GetComponent<PlayerControl>();
        uIGame = GetComponentInChildren<UIGame>();
    }

    #endregion
}
