using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment2 : ProcessingLite.GP21
{

    void Start()
    {
    }


    void Update()
    {
        Background(Color.blue);

        int z = 10;
        for (int i = 11; i < 21; i++)
        {
            z--;
            straightLine(10, z, i, 3);

            if(i % 3 == 0)
            {
                Stroke(0, 0, 0);
            }
            else
            {
                Stroke(169, 169, 169);
            }
        }
    }

    void straightLine(float posX, float posY, float posX2, float posY2)
    {
        Line(posX, posY, posX2, posY2 - 4);
    }
}
