using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FPSDisPlay : NghiaMonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textFPS;
    private float pollingTime = 1;
    private float time;
    private int frameCount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShowFPSDisPlay();
    }
    private void ShowFPSDisPlay()
    {
#if UNITY_EDITOR
#elif UNITY_ANDROID
        Application.targetFrameRate = 90;
#endif
        time += Time.deltaTime;
        frameCount++;
        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            textFPS.text = $"{frameRate} FPS";
            time -= pollingTime;
            frameCount = 0;
        }
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        textFPS = transform.Find("Text FPS").GetComponent<TextMeshProUGUI>();
    }
}
