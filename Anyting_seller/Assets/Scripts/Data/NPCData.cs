using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NpcData", menuName = "Game/NPC")]
public class NPCData : ScriptableObject
{
    public string npcName;

    public NPCState CustomerType;

    public int gold;
}