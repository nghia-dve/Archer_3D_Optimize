using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIMainButtonNormalAttack : NghiaMonoBehaviour
{
    [SerializeField]
    private Button buttonAttack;

    private bool isAttack = false;
    public bool IsAttack { get { return isAttack; } }
    // Start is called before the first frame update
    void Start()
    {
        AddEvenButton(buttonAttack);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void AddEvenButton(Button ButtonAttack)
    {
        EventTrigger eventTrigger = ButtonAttack.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((data) => { OnPointerDownDelegate((PointerEventData)data); });
        eventTrigger.triggers.Add(entry);
        entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerUp;
        entry.callback.AddListener((data) => { OnPointerUpDelegate((PointerEventData)data); });
        eventTrigger.triggers.Add(entry);
    }
    private void OnPointerDownDelegate(PointerEventData data)
    {
        isAttack = true;
    }
    private void OnPointerUpDelegate(PointerEventData data)
    {
        isAttack = false;
    }
    protected override void LoadComponent()
    {
        buttonAttack = transform.parent.transform.Find("Button Attack").GetComponent<Button>();
    }
}
