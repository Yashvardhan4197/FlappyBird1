using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
public class PopUpManager
{
   private GameEndManager gameEndManager;
   private GameStartManager gameStartManager;

    public PopUpManager(GameStartView gameStartView,GameEndView gameEndView)
    {
        gameStartManager = new GameStartManager(gameStartView);
        gameEndManager = new GameEndManager(gameEndView);
    }

    public void SetUIOpen(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 1.0f;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

    public void SetUIClosed(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 0f;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
}