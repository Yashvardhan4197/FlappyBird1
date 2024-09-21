public class GameEndManager
{
    private GameEndView gameEndView;
    public GameEndManager(GameEndView gameEndView)
    {
        this.gameEndView = gameEndView;
        gameEndView.SetController(this);
    }
}