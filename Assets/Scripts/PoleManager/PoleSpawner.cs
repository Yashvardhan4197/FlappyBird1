using UnityEngine;

public class PoleSpawner:MonoBehaviour
{
    public GameObject Poles;
    [SerializeField] Transform SpawnPos;
    [SerializeField] Transform EndPos;
    [SerializeField] int minHeight;
    [SerializeField] int maxHeight;
    public PoleSpawner(GameObject Poles)
    {
        this.Poles = Poles;
    }

    private void Start()
    {
        Poles=GameService.Instance.Poles;
        GameService.Instance.StartGameEvent += GameStarted;
        GameService.Instance.EndGameEvent += GameEnd;
    }

    public void GameStarted()
    {
        InvokeRepeating("StartGame",1, 2);
    }

    public void GameEnd()
    {
        CancelInvoke("StartGame");
    }


    private void StartGame()
    {
        GameObject newPole= Instantiate(Poles,transform);
        Vector3 newPos = new Vector3(SpawnPos.position.x, 0, 0);
        newPole.transform.position += Vector3.up * Random.Range(minHeight,maxHeight)+newPos;
        newPole.GetComponent<PoleView>().SetLeftSide(EndPos.position.x);
    }
}


