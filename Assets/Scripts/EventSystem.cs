using System;
using UnityEngine;

public class EventSystem
{
    public static Action<string> OnOpenText;
    
    public static void SendOpenText(string name)
    {
        if (OnOpenText != null)
        {
            OnOpenText.Invoke(name);
        }
    }
}
