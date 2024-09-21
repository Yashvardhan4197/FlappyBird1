using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class PopUpManager
{
   private GameEndManager gameEndManager;
   private GameStartManager gameStartManager;

    public PopUpManager(GameStartView gameStartView,GameEndView gameEndView)
    {
        gameStartManager = new GameStartManager(gameStartView);
        gameEndManager = new GameEndManager(gameEndView);
    }
}