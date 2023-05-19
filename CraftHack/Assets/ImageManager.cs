using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageManager : MonoBehaviour
{
    public LerpHack2 LerpHack2;
    public GameObject ControlImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LerpHack2.Lerped==true)
        {
            ControlImage.SetActive(false);
            LerpHack2.Lerped = false;
        }
    }
}
