using System;
using UnityEngine;

public class GameEndManager
{
    private GameEndView gameEndView;
    public GameEndManager(GameEndView gameEndView)
    {
        this.gameEndView = gameEndView;
        gameEndView.SetController(this);
        GameService.Instance.EndGameEvent += StopGame;
    }

    public void RestartGame()
    {
        CanvasGroup canvasGroup=gameEndView.GetCanvasGroup();
        GameService.Instance.GetPopUpService().SetUIClosed(canvasGroup);
        GameService.Instance.StartGameEvent?.Invoke();
    }

    public void StopGame()
    {
        Time.timeScale = 0f;
        CanvasGroup canvasGroup = gameEndView.GetCanvasGroup();
        GameService.Instance.GetPopUpService().SetUIOpen(canvasGroup);
    }

    public void BeforeGameStart()
    {
        CanvasGroup canvasGroup = gameEndView.GetCanvasGroup();
        GameService.Instance.GetPopUpService().SetUIClosed(canvasGroup);
    }

    ~GameEndManager()
    {
        GameService.Instance.EndGameEvent -= StopGame;
    }
}