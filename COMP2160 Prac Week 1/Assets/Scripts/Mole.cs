using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Collider))]

public class Mole : MonoBehaviour
{
    public Color InitialColor = Color.red;
    public Color ChangedColor = Color.black;
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

    }

    void OnMouseDown() 
    {
        sprite.color = ChangedColor;
    }
}
