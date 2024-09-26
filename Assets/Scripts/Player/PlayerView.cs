
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] float gravity;
    [SerializeField] float jumpPower;
    [SerializeField] Sprite[] PlayerSprites;
    private bool isPlaying;

    private void Start()
    {
        playerController.SetPlayer();
    }

    private void StartAnimationFromController() => playerController.StartAnimation();

    private voif StopAnimationFromController() => playerController.StopAnimation();

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
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
            {
                playerController?.JumpPlayer();
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
        CancelInvoke("StopAnimationFromController");
    }

    public Sprite[] GetPlayerImages() => PlayerSprites;

    public float GetGravity() { return gravity; }   

    public float GetJumpPower() {  return jumpPower; }

    //public Rigidbody2D GetRigidbody2D()=>this.gameObject.GetComponent<Rigidbody2D>();


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Dead");
        }
    }

}
