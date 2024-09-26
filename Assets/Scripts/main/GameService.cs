using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameService : MonoBehaviour
{
    //Singleton
    private static GameService instance;
    public static GameService Instance {  get { return instance; } }

    //Views
    [SerializeField] AnimationView baseView;
    [SerializeField] AnimationView bgView;
    [SerializeField] GameStartView gameStartView;
    [SerializeField] GameEndView gameEndView;
    [SerializeField] PlayerView playerView;

    //Data
    [SerializeField] float BgOffset;
    [SerializeField] float Baseoffset;
    [SerializeField] public GameObject Poles;
    
    //Services
    private BackgroundService bgService;
    private PopUpManager PopUpManager;
    private PlayerController playerController;
    public UnityAction StartGameEvent;
    public UnityAction EndGameEvent;   
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance.gameObject);
        }

        
    }
    private void OnEnable()
    {
        Init();
    }
    private void Init()
    {
        bgService = new BackgroundService(bgView,BgOffset,baseView,Baseoffset);
        PopUpManager = new PopUpManager(gameStartView,gameEndView);
        playerController = new PlayerController(playerView);
    }

    private void DestroyPipes()
    {
        PoleView[] Objects= FindObjectsOfType<PoleView>();

        for(int i = 0; i < Objects.Length; i++)
        {
            Destroy(Objects[i].gameObject);
        }
    }

    public PopUpManager GetPopUpService()=> PopUpManager;

    public BackgroundService GetBackgroundService()=>bgService;

    public PlayerController GetPlayerController() => playerController; 

}
