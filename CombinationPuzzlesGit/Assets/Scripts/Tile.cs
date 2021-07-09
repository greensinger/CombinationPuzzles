using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    bool isRotating;

    int rotationAngle;
    float rotationSpeed = 300;

    public enum Angles
    {
        SQUARE, 
        TRIANGLE,
        HEXAGON
    }

    public Angles angles;

    void Start()
    {
        switch(angles)
        {
            case Angles.HEXAGON:
                {
                    rotationAngle = 60;
                }
            break;
            case Angles.SQUARE:
                {
                    rotationAngle = 90;
                }
            break;
            case Angles.TRIANGLE:
                {
                    rotationAngle = 120;
                }
            break;
        }
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))  //LEFT MOUSE BUTTON
        {
            Debug.Log("Left click happened");
        }
        else if(Input.GetMouseButtonDown(1))   //RIGHT MOUSE BUTTON
        {
            Debug.Log("Right click happened");
        }
    }

    IEnumerator Rotate()
    {
        if(isRotating)
        {
            yield break;
        }

        isRotating = true;

        Quaternion rotation = transform.rotation * Quaternion.Euler(0, 0, rotationAngle);

        

        isRotating = false;
    }


}
