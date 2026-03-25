using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public float mood = 100;
    public float currentMood = 0.0f;

    NPCState.EmotionState eState;
    NPCState.CustomerType cType;

    public GameObject requireItem;

    void Start()
    {
        SetEState();
        SetCState();
    }

    void Update()
    {
        
    }

    void SetEState()
    {
        currentMood = Random.Range(40, 100);

        if (currentMood >= 90)
            eState = NPCState.EmotionState.Happy;
        else if (currentMood >= 70)
            eState = NPCState.EmotionState.NotBad;
        else if (currentMood >= 60)
            eState = NPCState.EmotionState.SoSo;
        else if (currentMood >= 50)
            eState = NPCState.EmotionState.Normal;
        else
            eState = NPCState.EmotionState.ListLess;
        

        Debug.Log(eState);
    }
    void SetCState()
    {
        var cValues = System.Enum.GetValues(typeof(NPCState.CustomerType));
        int randomCType = Random.Range(0, cValues.Length);
        Debug.Log(randomCType);
    }
}
