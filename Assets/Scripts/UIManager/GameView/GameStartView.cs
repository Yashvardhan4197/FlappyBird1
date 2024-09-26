
using UnityEngine;
using UnityEngine.UI;

public class GameStartView : MonoBehaviour
{
    private GameStartManager gameStartManager;
    [SerializeField] Button startGameButton;
    [SerializeField] CanvasGroup startGameSection;

    private void Start()
    {
        gameStartManager.BeforeGameStart();
    }

    public void SetController(GameStartManager gameStartManager)
    {
        this.gameStartManager = gameStartManager;
        startGameButton.onClick.AddListener(OnStartGameButtonClicked);
    }

    public void OnStartGameButtonClicked()
    {
        gameStartManager.GameStart();
    }

    public CanvasGroup GetCanvasGroup() => startGameSection;

}
