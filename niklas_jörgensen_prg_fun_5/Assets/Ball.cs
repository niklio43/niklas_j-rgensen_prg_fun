using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Ball : ProcessingLite.GP21
{
    public Vector2 position;
    Vector2 velocity;
    public float size;
    Color color;

    public Ball(float x, float y, float size, Color color)
    {
        position = new Vector2(x, y);

        velocity = new Vector2();
        velocity.x = Random.Range(0, 11) - 5;
        velocity.y = Random.Range(0, 11) - 5;

        this.size = size;
        this.color = color;
    }

    public void Draw()
    {
        int r = Mathf.RoundToInt(this.color.r * 255);
        int g = Mathf.RoundToInt(this.color.g * 255);
        int b = Mathf.RoundToInt(this.color.b * 255);

        Fill(r, g, b);
        Circle(position.x, position.y, this.size);
    }

    public void UpdatePos()
    {
        position += velocity * Time.deltaTime;

        if(position.x < 0 || position.x > Width)
        {
            velocity.x *= -1;
        }

        if (position.y < 0 || position.y > Height)
        {
            velocity.y *= -1;
        }
    }
}