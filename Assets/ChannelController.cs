using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ChannelController : MonoBehaviour
{   
    public AudioMixer Mixer_Ref;

    public bool IsChannelOn = true;

    public string Parameter_To_Change = "Please Set The Name Of The Exposed Parameter From The Selected Mixer";

    public float Low_Value = -80f;
    public float High_Value = 0f;

    public void Toggle_Channel()
    {
        if (IsChannelOn)
        {
            Mixer_Ref.SetFloat(Parameter_To_Change, Low_Value);
        }
        else
        {
            Mixer_Ref.SetFloat(Parameter_To_Change, High_Value);
        }

        IsChannelOn = !IsChannelOn;
    }
}
