
using UnityEngine;

public class GameStartView : MonoBehaviour
{
    private GameStartManager gameStartManager;
    public void SetController(GameStartManager gameStartManager)
    {
        this.gameStartManager = gameStartManager;
    }
}
