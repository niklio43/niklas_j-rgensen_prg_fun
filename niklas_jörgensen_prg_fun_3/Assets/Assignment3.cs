using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Assignment3 : ProcessingLite.GP21
{
    public Vector2 circlePosition;
    public float diameter = 0.2f;
    public Vector2 mousePos;
    public Vector2 speed = new Vector2(0, 0);

    void Update()
    {
        Background(0);
        Draw();

        if (Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


            Line(circlePosition.x, circlePosition.y, mousePos.x, mousePos.y);

            Vector2 Angle = new Vector2(circlePosition.x - mousePos.x, circlePosition.y - mousePos.y);

            Move(Angle);

        }

    }

    public void Draw()
    {

        circlePosition.x += speed.x * Time.deltaTime;
        circlePosition.y += speed.y * Time.deltaTime;

        if ((circlePosition.y - (diameter / 2)) < 0 || (circlePosition.y + (diameter / 2)) > Height)
        {
            speed.y *= -1;
        }

        if(circlePosition.x - (diameter / 2) < 0 || (circlePosition.x + (diameter / 2)) > Width)
        {
            speed.x *= -1;
        }

        if(circlePosition.x == 0 && circlePosition.y == 0)
        {
            circlePosition.x = 20;
            circlePosition.y = 10;
        }
        Circle(circlePosition.x, circlePosition.y, diameter);

    }


    void Move(Vector2 Angle)
    {

        if(mousePos.x > 0 && mousePos.x < Width)
        {
            if(mousePos.y > 0 && mousePos.y < Height)
            {
                speed.x = (0.5f * Angle.x) * -1;
                speed.y = (0.5f * Angle.y) * -1;
            }
        }
    }
}


