using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment5 : ProcessingLite.GP21
{
    Ball[] balls;
    Player player;
    int numberOfBalls = 10;
    bool state = true;
    int textSize = 30;

    void Start()
    {

        balls = new Ball[numberOfBalls];

        player = new Player();


        for (int i = 0; i < balls.Length; i++)
        {
            balls[i] = new Ball(5, 5, 0.2f, Color.cyan);
        }

    }

    void Update()
    {
        if (state)
        {
            Background(255, 50, 50);


            for (int i = 0; i < balls.Length; i++)
            {
                balls[i].UpdatePos();
                balls[i].Draw();

                bool hit = CircleCollision(
                    balls[i].position.x,
                    balls[i].position.y,
                    balls[i].size,
                    player.position.x,
                    player.position.y,
                    player.size);

                if (hit)
                {
                    state = false;
                }
            }

            player.UpdatePlayer();
        }else 
        {
            TextSize(textSize);
            Text("GAME OVER", Width / 2, Height / 2);
        }
    }

    bool CircleCollision(float x1, float y1, float size1, float x2, float y2, float size2)
    {
        float maxDistance = (size1/2) + (size2/2);

        if (Mathf.Abs(x1 - x2) > maxDistance || Mathf.Abs(y1 - y2) > maxDistance)
        {
            return false;
        }

        else if (Vector2.Distance(new Vector2(x1, y1), new Vector2(x2, y2)) > maxDistance)
        {
            return false;
        }

        else
        {
            return true;
        }
    }
}
