
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] float gravity;
    [SerializeField] float jumpPower;
    [SerializeField] Sprite[] PlayerSprites;
    [SerializeField] Transform startPos;
    private bool isPlaying;

    private void Start()
    {
        playerController.SetPlayer();
    }

    private void StartAnimationFromController() => playerController.StartAnimation();

    public void SetController(PlayerController playerController)
    {
        this.playerController = playerController;
        GameService.Instance.StartGameEvent += SetIsPlaying;
    }

    public void SetIsPlaying()
    {
        isPlaying = true;
    }

    public void SetIsPlaying(bool isPlaying)
    {
        this.isPlaying = isPlaying;
    }


    private void Update()
    {
        if (isPlaying == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                playerController?.JumpPlayer();
                GameService.Instance.GetSoundManager().PlaySound(Sound.FLY);
            }

            playerController?.Update();
        }

    }

    public void StartAnimation()
    {
        InvokeRepeating("StartAnimationFromController", 1, 1);

    }

    public void StopAnimation()
    {
        CancelInvoke("StartAnimationFromController");
    }

    public Sprite[] GetPlayerImages() => PlayerSprites;

    public float GetGravity() { return gravity; }   

    public float GetJumpPower() {  return jumpPower; }

    public Transform GetStartPos() { return startPos; }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Enemy")
        {
            playerController.EndGame();
            GameService.Instance.GetSoundManager().PlaySound(Sound.END);
        }

        if(collision.gameObject.tag == "Score")
        {
            GameService.Instance.GetPopUpService().GetScoreController().IncreaseScore();
            GameService.Instance.GetSoundManager().PlaySound(Sound.SCORE);
        }

    }

}
