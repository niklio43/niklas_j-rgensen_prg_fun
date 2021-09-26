using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment4 : ProcessingLite.GP21
{
    float posY = 0;
    float diameter = 2;
    float speed = 5f;
    Vector2 position;
    Vector2 position2;
    Vector2 velocity;
    Vector2 acceleration;

    void Start()
    {
        position = new Vector2(Width / 2, Height / 2);
        position2 = new Vector2(Width / 2, Height / 2);
    }

    void Update()
    {
        Background(255, 50, 50);

        float x = Input.GetAxisRaw("Horizontal") * speed *Time.deltaTime;
        float y = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        acceleration = new Vector2(x, y);

        velocity += acceleration * Time.deltaTime;

        if(velocity.magnitude > 0.05f)
        {
            velocity = velocity.normalized * 0.05f;
        }
        else if (acceleration == Vector2.zero)
        {
            velocity *= 0.99f;
        }

        Border();

        position += velocity;

        position2 += new Vector2(x, y);


        Draw();
    }

    void Draw()
    {
        Circle(position.x, position.y, diameter);
        Circle(position2.x, position2.y, diameter);
    }

    void Border()
    {
        //first ball X
        if (position.x < 0)
        {
            position.x += Width;
        }
        if (position.x > Width)
        {
            position.x -= Width;
        }

        //first ball Y
        if (position.y < 0)
        {
            position.y += Height;
        }
        if (position.y > Height)
        {
            position.y -= Height;
        }

        //second ball X
        if (position2.x < 0)
        {
            position2.x += Width;
        }
        if (position2.x > Width)
        {
            position2.x -= Width;
        }

        //second ball Y
        if (position2.y < 0)
        {
            position2.y += Height;
        }
        if (position2.y > Height)
        {
            position2.y -= Height;
        }
    }
}
