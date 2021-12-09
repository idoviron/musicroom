using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEvent_Tester : MonoBehaviour
{
    public bool isTestUnityEvent;

    public UnityEvent OnTest;

    private void Update()
    {
        if (isTestUnityEvent)
        {
            isTestUnityEvent = false;
            if (OnTest != null)
            {
                OnTest.Invoke();
            }    
        }
    }
}
