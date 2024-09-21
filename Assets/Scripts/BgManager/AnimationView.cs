using UnityEngine;

public class AnimationView : MonoBehaviour
{
    private AnimationController animationController;
    private bool isPlaying;
    public void SetController(AnimationController bgUIController)=>animationController=bgUIController;

    public MeshRenderer meshRenderer;


    private void Update()
    {
        animationController?.Update();   
    }
}
