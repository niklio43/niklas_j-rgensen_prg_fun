using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : ProcessingLite.GP21
{

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("hej nummer: " + i);
        }
    }


    void Update()
    {
        Background(Color.black);

        letterN(4,7);
        letterI(7, 7);
        letterK(8, 7);
        letterL(11, 7);
        letterA(16, 7);
        letterS(19, 7);
        drawRect();
        drawEllipse();
    }

    void letterN(int posX, int posY)
    {
        Line(posX, posY, posX, posY - 4);
        Line(posX, posY, posX + 2, posY - 4);
        Line(posX + 2, posY, posX +2, posY - 4);
    }

    void letterI(int posX, int posY)
    {
        Line(posX, posY, posX, posY - 4);
    }

    void letterK(int posX, int posY)
    {
        Line(posX, posY, posX, posY - 4);
        Line(posX, posY - 2, posX + 2, posY - 4);
        Line(posX + 2, posY, posX, posY - 2);
    }

    void letterL(int posX, int posY)
    {
        Line(posX, posY, posX, posX - 8);
        Line(posX, posY - 4, posX + 2, posX - 8);
    }

    void letterA(int posX, int posY)
    {
        Line(posX, posY, posX - 2, posY - 4);
        Line(posX - 1, posY - 2, posX + 1, posY - 2);
        Line(posX, posY, posX + 2, posY - 4);
    }

    void letterS(int posX, int posY)
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
