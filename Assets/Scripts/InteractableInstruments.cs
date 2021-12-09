using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableInstruments : MonoBehaviour
{
    public UnityEvent instrumentCollisionStarted;
    public UnityEvent instrumentCollisionEnded;

    private void OnCollisionEnter(Collision collision)
    {
        if (instrumentCollisionStarted != null)
        { 
            instrumentCollisionStarted.Invoke();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (instrumentCollisionEnded != null)
        { 
            instrumentCollisionEnded.Invoke();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
