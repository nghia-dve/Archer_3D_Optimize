using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUserInfo : NghiaMonoBehaviour
{
    [SerializeField]
    private Image imageHpPlayer;
    public Image ImageHpPlayer { get { return imageHpPlayer; } }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ChangeHpInUI();
    }
    private void ChangeHpInUI()
    {
        var maxHp = UIManager.Instance.PlayerControl.MaxHpPlayer;
        var hp = UIManager.Instance.PlayerControl.HpPlayer;
        imageHpPlayer.fillAmount = hp / maxHp;
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        imageHpPlayer = transform.Find("Slider_Hp").Find("Fill_Area")
            .Find("Fill").GetComponent<Image>();
    }
}
