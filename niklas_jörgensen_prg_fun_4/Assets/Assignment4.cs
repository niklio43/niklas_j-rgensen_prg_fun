using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment4 : ProcessingLite.GP21
{
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
        position.x = (position.x + Width) % Width;
        position.y = (position.y + Height) % Height;
        position2.x = (position2.x + Width) % Width;
        position2.y = (position2.y + Height) % Height;
    }
}
