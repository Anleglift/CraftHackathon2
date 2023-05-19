using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class LerpHack : MonoBehaviour
{
    public bool Started = false;
    public GameObject Site;
    public GameObject Ads;
    public GameObject Permanent;
    public GameObject Control;
    public GameObject EndPos;
    public CanvasGroup canvasGroup;
    public float duration = 1f;
    private bool isLerping1 = false;
    private float currentTime = 0f;
    private float currentTime1 = 0f;
    private bool isLerping = false;
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

            Control.SetActive(true);
           
            if (isLerping)
            {
                currentTime += Time.deltaTime;
                float t = Mathf.Clamp01(currentTime / duration);
                canvasGroup.alpha = t;

                if (t >= 1f)
                {
                    isLerping = false;
                    Invoke("ShowEverything", 0.3f);
                }
            }
        }
    }
    private void ShowEverything()
    {
Permanent.SetActive(false);
                    Ads.SetActive(false);
                    Control.SetActive(false);
                    Site.SetActive(true);
    }
    private void StartLerping()
    {
        currentTime = 0f;
        isLerping = true;
    }
}
