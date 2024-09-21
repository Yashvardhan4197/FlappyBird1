using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleView : MonoBehaviour
{
    [SerializeField] Transform UpPole;
    [SerializeField] Transform DownPole;
    [SerializeField] float speed;
    [SerializeField] int gap;
    private float rightPos;
    private float leftPos;
    private void Start()
    { 
        UpPole.position += Vector3.up* gap;
        DownPole.position+= Vector3.down* gap;
        
    }

    private void Update()
    {
        if (transform.position.x<=leftPos)
        {
            Destroy(gameObject);
        }
        transform.position+=Vector3.left*Time.deltaTime*speed;
    }

    public void SetRightSide(float rightPos) => this.rightPos = rightPos;
    public void SetLeftSide(float leftPos)=>this.leftPos = leftPos;
}
