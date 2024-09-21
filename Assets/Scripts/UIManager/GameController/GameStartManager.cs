public class GameStartManager
{

    private GameStartView gameStartView;
    public GameStartManager(GameStartView gameStartView) 
    {
        this.gameStartView = gameStartView;
        gameStartView.SetController(this);
    }

}