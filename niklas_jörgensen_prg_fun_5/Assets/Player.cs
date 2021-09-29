using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ProcessingLite.GP21
{
    public Vector2 position;
    public float size = 0.75f;

    public Player()
    {
        position = new Vector2(Width / 2, Height / 2);
    }

    public void UpdatePlayer()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        position += new Vector2(x, y) * Time.deltaTime * 5;

        Circle(position.x, position.y, size);
    }
}
