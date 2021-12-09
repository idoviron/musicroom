using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugText : MonoBehaviour
{
    public string TEXT = "WORKING!";
    public void Debug_Text()
    {
        Debug.Log(TEXT);
    }
}
