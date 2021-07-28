using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class Mole : MonoBehaviour
{
    public Color InitialColor = Color.red;
    public Color ChangedColor = Color.black;
    public float Timer = 5.0f;
    private float PrivateTimer;
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = InitialColor;
    }

    // Update is called once per frame
    void Update()
    {
        PrivateTimer -= Time.deltaTime;
        if(PrivateTimer < 0) 
        {
            sprite.color = InitialColor;
        }
    }

    void OnMouseDown() 
    {
        PrivateTimer = Timer;
        sprite.color = ChangedColor; 
    }
}
