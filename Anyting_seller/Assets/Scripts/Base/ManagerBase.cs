using UnityEngine;

/// <summary>
/// 모든 매니저가 공통으로 상속받는 기본 클래스입니다.
/// </summary>
public abstract class ManagerBase : MonoBehaviour
{
    /// <summary>
    /// 매니저 초기화 시 호출되는 기본 함수입니다.
    /// </summary>
    public virtual void Init()
    {
        Debug.Log($"Init 했습니다 {gameObject.name}");
    }
}