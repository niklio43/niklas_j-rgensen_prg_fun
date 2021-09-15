using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : ProcessingLite.GP21
{

    float animPosY = 7;

    void Start()
    {
    }


    void Update()
    {
        Background(Color.black);

        letterN(4, animPosY);
        letterI(7, 7);
        letterK(8, animPosY);
        letterL(11, 7);
        letterA(16, animPosY);
        letterS(19, 7);
        drawRect();
        drawEllipse();

        if (animPosY < 8)
        {
            animPosY += Time.deltaTime;
        }

    }

    void letterN(float posX, float posY)
    {
        Line(posX, posY, posX, posY - 4);
        Line(posX, posY, posX + 2, posY - 4);
        Line(posX + 2, posY, posX +2, posY - 4);
    }

    void letterI(float posX, float posY)
    {
        Line(posX, posY, posX, posY - 4);
    }

    void letterK(float posX, float posY)
    {
        Line(posX, posY, posX, posY - 4);
        Line(posX, posY - 2, posX + 2, posY - 4);
        Line(posX + 2, posY, posX, posY - 2);
    }

    void letterL(float posX, float posY)
    {
        Line(posX, posY, posX, posX - 8);
        Line(posX, posY - 4, posX + 2, posX - 8);
    }

    void letterA(float posX, float posY)
    {
        Line(posX, posY, posX - 2, posY - 4);
        Line(posX - 1, posY - 2, posX + 1, posY - 2);
        Line(posX, posY, posX + 2, posY - 4);
    }

    void letterS(float posX, float posY)
    {
        Line(posX, posY, posX + 2, posY);
        Line(posX, posY, posX, posY - 2);
        Line(posX, posY - 2, posX + 2, posY - 2);
        Line(posX + 2, posY - 2, posX + 2, posY - 4);
        Line(posX, posY - 4, posX + 2, posY - 4);
    }

    void drawEllipse()
    {
        Stroke(214, 43, 186);
        Fill(105, 233, 50);
        Ellipse(14, 8.5f, 2, 2);
    }

    void drawRect()
    {
        Stroke(214, 43, 186);
        Fill(255, 50, 50);
        Rect(1, 6, 3, 2);
    }

}
