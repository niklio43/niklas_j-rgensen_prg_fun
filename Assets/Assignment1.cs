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

        letterN();
        letterI();
        letterK();
        letterL();
        letterA();
        letterS();
        drawRect();
        drawEllipse();
    }

    void letterN()
    {
        Line(4, 7, 4, 3);
        Line(4, 7, 6, 3);
        Line(6, 7, 6, 3);
    }

    void letterI()
    {
        Line(7, 7, 7, 3);
    }

    void letterK()
    {
        Line(8, 7, 8, 3);
        Line(8, 5, 10, 3);
        Line(10, 7, 8, 5);
    }

    void letterL()
    {
        Line(11, 7, 11, 3);
        Line(11, 3, 13, 3);
    }

    void letterA()
    {
        Line(16, 7, 14, 3);
        Line(15, 5, 17, 5);
        Line(16, 7, 18, 3);
    }

    void letterS()
    {
        Line(19, 7, 21, 7);
        Line(19, 7, 19, 5);
        Line(19, 5, 21, 5);
        Line(21, 5, 21, 3);
        Line(19, 3, 21, 3);
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
