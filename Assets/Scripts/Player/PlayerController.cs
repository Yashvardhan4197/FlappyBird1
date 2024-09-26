
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController
{
    private PlayerView playerView;
    Sprite[] sprites;
    int spriteIndex = 0;
    Vector3 dir;

    public PlayerController(PlayerView playerView)
    {
        this.playerView = playerView;
        this.playerView.SetController(this);
        sprites = playerView.GetPlayerImages();
        GameService.Instance.StartGameEvent += OnGameStart;
        GameService.Instance.EndGameEvent += OnGameEnd;

    }

    public void SetPlayer()
    {

    }

    public void OnGameStart()
    {
        playerView.StartAnimation();
        playerView.gameObject.transform.position = playerView.GetStartPos().position;
        playerView.gameObject.transform.eulerAngles = playerView.GetStartPos().eulerAngles;
    }

    public void StartAnimation()
    {
        
        if(spriteIndex>=sprites.Length)
        {
            spriteIndex = 0;
        }
        playerView.GetComponent<SpriteRenderer>().sprite = sprites[spriteIndex];
        spriteIndex++;

    }

    public void JumpPlayer()
    {
        dir = Vector3.up *playerView.GetJumpPower();
    }

    public void Update()
    {
        dir += Vector3.down * playerView.GetGravity() * Time.deltaTime;
        playerView.gameObject.transform.position += dir * Time.deltaTime;

        Vector3 rot = playerView.transform.eulerAngles;
        rot.z = dir.y * 5;
        playerView.transform.eulerAngles = rot;

    }

    public void OnGameEnd()
    {
        playerView.SetIsPlaying(false);
        playerView.gameObject.transform.position = playerView.GetStartPos().position;
        playerView.gameObject.transform.eulerAngles = playerView.GetStartPos().eulerAngles;
        playerView.StopAnimation();
    }

    public void EndGame()
    {
        GameService.Instance.EndGameEvent?.Invoke();
    }
}

