using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCState : MonoBehaviour
{
    public enum EmotionState
    {
        None = 0,
        Normal = 1,
        Happy = 2,
        NotBad = 3,
        Angry = 4,
        Sad = 5,
        SoSo = 6,
    }
    EmotionState EState = EmotionState.None;

    public enum CustomerType
    {
        None = 0,
        Haggler = 1, // 비싸다는놈
        Rude = 2, // 무례한놈
        Dirty = 3, // 노숙자
        Foreigner = 4, // 외국인
        Drunk = 5, // 술취한놈
        Thrower = 6, // 물건던지는놈
    }
    CustomerType CState = CustomerType.None;
}
