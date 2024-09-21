
using System;
using UnityEngine;

public class AnimationController 
{

    private float offset;
    private MeshRenderer MeshRenderer;
    public AnimationController(float offest,AnimationView bgUIView)
    {
        this.offset = offest;
        bgUIView.SetController(this);
        MeshRenderer=bgUIView.meshRenderer;
    }

    public void StartAnimation()
    {
        MeshRenderer.material.mainTextureOffset += new Vector2(offset*Time.deltaTime, 0);
    }
    public void Update()
    {
        StartAnimation();
    }
}
