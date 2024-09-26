
using UnityEngine;
using UnityEngine.UI;

public class GameEndView : MonoBehaviour
{
    private GameEndManager gameEndManager;
    [SerializeField] CanvasGroup canvasGroup;
    [SerializeField] Button restartButton;
    public void SetController(GameEndManager gameEndManager)
    {
        this.gameEndManager = gameEndManager;
    }

    public CanvasGroup GetCanvasGroup() => canvasGroup;

    private void Start()
    {
        restartButton.onClick.AddListener(RestartGame);
        gameEndManager.BeforeGameStart();
    }

    private void RestartGame()
    {
        gameEndManager.RestartGame();
    }
}
