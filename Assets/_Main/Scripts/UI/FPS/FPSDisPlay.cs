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
    void Start()
    {
#if UNITY_STANDALONE_WIN
        Application.targetFrameRate = 60;
#elif UNITY_ANDROID
        Application.targetFrameRate = 90;
#endif
    }
    void Update()
    {
        ShowFPSDisPlay();
    }
    private void ShowFPSDisPlay()
    {
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
