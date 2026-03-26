using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : ManagerBase
{
    /// <summary>
    /// 게임상태
    /// </summary>
    public GameState gameState = GameState.None;

    /// <summary>
    /// 날짜
    /// </summary>

    public int day = 0;

    /// <summary>
    /// 게임상태 변경
    /// </summary>
    /// <param name="changeState">변경할 상태</param>

    public void ChangeState(GameState changeState)
    {
        gameState = changeState;
    }
}
