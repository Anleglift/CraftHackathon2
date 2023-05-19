using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpHack2 : MonoBehaviour
{
    public bool Started = false;
    public GameObject Site;
    public GameObject Ads;
    public GameObject Permanent;
    public GameObject Control;
    public GameObject AdControl;
    public GameObject EndPos;
    public CanvasGroup canvasGroup;
    public CanvasGroup second;
    public float duration = 1f;
    private bool isLerping1 = false;
    private float currentTime = 0f;
    private float currentTime1 = 0f;
    private bool isLerping = false;
    public bool Lerped=false;
    public void Start()
    {
        Control.SetActive(false);
    }
    public void StartTransition()
    {
        Started = true;
        StartLerping();
    }
    public void Update()
    {
        if (Started)
        {
                    Invoke("ShowEverything",0.3f);
        }
    }
    private void ShowEverything()
    {
        Permanent.SetActive(true);
        Ads.SetActive(true);
        Site.SetActive(false);
        Lerped = true;
    }
    private void StartLerping()
    {
        currentTime = 0f;
        isLerping = true;
    }
}
