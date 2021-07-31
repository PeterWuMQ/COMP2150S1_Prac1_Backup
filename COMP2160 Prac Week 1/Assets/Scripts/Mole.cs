using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class Mole : MonoBehaviour
{
    public Color DownColor = Color.black;
    public Color UpColor = Color.white;
    public Color MissedColor = Color.red;
    public float MissedTimer = 5.0f;
    public float ResetTimer = 3.0f;
    public float MinRandom = 1.0f;
    public float MaxRandom = 7.0f;
    private float UpTimer;
    private float PrivateResetTimer;
    private float PrivateMissedTimer;
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = DownColor;
        UpTimer = Random.Range(MinRandom, MaxRandom);
        PrivateResetTimer = ResetTimer;
        PrivateMissedTimer = MissedTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (sprite.color == DownColor)
        {
            UpTimer -= Time.deltaTime;
            if (UpTimer < 0)
            {
                sprite.color = UpColor;
                UpTimer = Random.Range(MinRandom, MaxRandom);
            }
        }

        if (sprite.color == UpColor)
        {
            PrivateMissedTimer -= Time.deltaTime;
            if (PrivateMissedTimer < 0)
            {
                sprite.color = MissedColor;
                PrivateMissedTimer = MissedTimer;
            }
        }

        if (sprite.color == MissedColor)
        {
            PrivateResetTimer -= Time.deltaTime;
            if (PrivateResetTimer < 0)
            {
                sprite.color = DownColor;
                PrivateResetTimer = ResetTimer;
            }
        }

    }

    void OnMouseDown()
    {
        if (sprite.color == UpColor)
        {
            sprite.color = DownColor;
        }

    }
}
