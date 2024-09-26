using UnityEngine;

public class GameStartManager
{

    private GameStartView gameStartView;
    public GameStartManager(GameStartView gameStartView) 
    {
        this.gameStartView = gameStartView;
        gameStartView.SetController(this);
        GameService.Instance.StartGameEvent += StartGameSection;
        
        
    }

    public void BeforeGameStart()
    {
        CanvasGroup canvasGroup = this.gameStartView.GetCanvasGroup();
        GameService.Instance.GetPopUpService().SetUIOpen(canvasGroup);
    }

    public void GameStart()
    {
        GameService.Instance.StartGameEvent?.Invoke();
    }

    private void StartGameSection()
    {
        Time.timeScale=1.0f;
        CanvasGroup canvasGroup= gameStartView.GetCanvasGroup();
        GameService.Instance.GetPopUpService().SetUIClosed(canvasGroup);
    }
    

    ~GameStartManager()
    {
        GameService.Instance.StartGameEvent -= StartGameSection;
    }

}