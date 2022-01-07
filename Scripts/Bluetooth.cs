using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bluetooth : MonoBehaviour
{
    void Start()
    {
        setBluetoothEnabled();
    }
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    public void setBluetoothEnabled()
    {
        using (AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity"))
        {
            try
            {
                using (var BluetoothManager = activity.Call<AndroidJavaObject>("getSystemService", "bluetooth"))
                {
                    using (var BluetoothAdapter = BluetoothManager.Call<AndroidJavaObject>("getAdapter"))
                    {
                        BluetoothAdapter.Call<bool>("enable");
                    }

                }
            }
            catch (Exception e)
            {
                print("error");
            }
        }
    }
}
