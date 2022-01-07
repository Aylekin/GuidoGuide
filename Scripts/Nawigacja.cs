using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nawigacja : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Maps()
    {
        Application.OpenURL("https://www.google.pl/maps/place/Kopalnia+Guido/@50.2895353,18.7895733,17z/data=!3m1!4b1!4m5!3m4!1s0x4711325bcc247ac1:0xebe9dca4e15bb28d!8m2!3d50.2895319!4d18.791762");
        
    }
    public void Telefon()
    {
        Application.OpenURL("tel://123456789");


    }
    public void StronaWWW()
    {
        Application.OpenURL("https://kopalniaguido.pl/index.php");
        
    }

    public void Wydarzenia()
    {
        Application.OpenURL("https://kopalniaguido.pl/index.php/imprezy");
    }
}
