using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image image;
    public Image image2;
    void Start()
    {
        image = GetComponent<Image>();
        image2 = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        Color c = image.color;
        if (Input.GetMouseButton(0) || Input.touchCount == 1)
        {

            c.a = 50;
            image.color = c;
            image2.color = c;

        }
        else
           
        c.a = 165;
        image.color = c;
        image2.color = c;
    }
}
