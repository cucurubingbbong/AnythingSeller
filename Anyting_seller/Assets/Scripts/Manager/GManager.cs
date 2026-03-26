using UnityEngine;

/// <summary>
/// 씬에 배치된 주요 매니저를 순서대로 초기화합니다.
/// </summary>
public class GManager : ManagerBase
{
    /// <summary>
    /// 초기화할 매니저 목록입니다.
    /// </summary>
    public ManagerBase[] managerBase;

    /// <summary>
    /// 게임매니저
    /// </summary>
    public GameManager gameManager;

    public static GManager Instance { get; private set; }

    public override void Init()
    {
        base.Init();
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    /// <summary>
    /// 자신과 등록된 매니저를 모두 초기화합니다.
    /// </summary>
    void Awake()
    {
        Init();
        foreach (ManagerBase managers in managerBase)
        {
            managers.Init();
        }

    }
}