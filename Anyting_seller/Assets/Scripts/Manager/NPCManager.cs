using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public float mood = 100;
    public float currentMood = 0.0f;

    public NPCState emotionState;

    void Start()
    {
        currentMood = Random.Range(50, 100);
        Array values = Enum.GetValues(typeof())
    }

    void Update()
    {
        
    }
}
