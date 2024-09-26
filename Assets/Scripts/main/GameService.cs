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
    [SerializeField] ScoreView scoreView;

    //Data
    [SerializeField] float BgOffset;
    [SerializeField] float Baseoffset;
    [SerializeField] public GameObject Poles;
    [SerializeField] AudioSource audioSource;
    [SerializeField] SoundType[] soundTypes;
    
    //Services
    private BackgroundService bgService;
    private PopUpManager PopUpManager;
    private PlayerController playerController;
    private SoundManager soundManager;
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
        EndGameEvent += DestroyPipes;
        StartGameEvent += PlayStartSound;
    }

    private void OnDisable()
    {
        StartGameEvent -= PlayStartSound;
        EndGameEvent -= DestroyPipes;
    }
    private void Init()
    {
        bgService = new BackgroundService(bgView,BgOffset,baseView,Baseoffset);
        PopUpManager = new PopUpManager(gameStartView,gameEndView,scoreView);
        playerController = new PlayerController(playerView);
        soundManager=new SoundManager(audioSource,soundTypes);
    }

    private void DestroyPipes()
    {
        PoleView[] Objects= FindObjectsOfType<PoleView>();

        for(int i = 0; i < Objects.Length; i++)
        {
            Destroy(Objects[i].gameObject);
        }
    }

    private void PlayStartSound()=> soundManager.PlaySound(Sound.START);

    public PopUpManager GetPopUpService()=> PopUpManager;

    public BackgroundService GetBackgroundService()=>bgService;

    public PlayerController GetPlayerController() => playerController; 

    public SoundManager GetSoundManager() => soundManager;

}
