using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    /// <summary>
    /// 무게
    /// </summary>
    public float weight {get; private set; } = 0.0f;

    /// <summary>
    /// 기본가격
    /// </summary>
    public int basePrice {get; private set;} = 0;

    /// <summary>
    /// 아이템의 가치
    /// 아이템의 가격은 기본가격 * 아이템의 가치로 결정됩니다. ( 흥정전 )
    /// </summary>
    public float itemValue {get; private set;}= 0.00f;

    /// <summary>
    /// 아이템의 갯수
    /// </summary>
    public int count = 1;




}
