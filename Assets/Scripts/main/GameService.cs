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

    //Data
    [SerializeField] float BgOffset;
    [SerializeField] float Baseoffset;
    [SerializeField] public GameObject Poles;
    
    //Services
    public BackgroundService bgService;
    public PopUpManager PopUpManager;
    public PoleSpawner PoleSpawner;
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

        Init();
    }

    private void Init()
    {
        bgService = new BackgroundService(bgView,BgOffset,baseView,Baseoffset);
        PopUpManager = new PopUpManager(gameStartView,gameEndView);
        PoleSpawner = new PoleSpawner(Poles);
    }

}
