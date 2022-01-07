using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoToggle : MonoBehaviour
{
    public GameObject legenda;
    public Toggle button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(button.isOn)
        {
            legenda.SetActive(true);
        }
        else
        {
            legenda.SetActive(false);
        }
    }
}
