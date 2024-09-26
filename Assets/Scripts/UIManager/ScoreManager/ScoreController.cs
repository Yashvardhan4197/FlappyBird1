
public class ScoreController
{
    private ScoreView ScoreView;
    private int score;
    public ScoreController(ScoreView scoreView)
    {
        this.ScoreView = scoreView;
        GameService.Instance.StartGameEvent += ResetScore;
    }

    private void UpdateScore()
    {
        ScoreView.GetScoreText().text = score.ToString();
    }

    public void IncreaseScore()
    {
        score++;
        UpdateScore();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScore();
    }

    ~ScoreController()
    {
        GameService.Instance.StartGameEvent -= ResetScore;
    }
}


