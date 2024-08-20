using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TouchScale : MonoBehaviour
{
    Touch touch1;

    private float distance, distanceTemp;

    private Vector2 secondTouchPos = new Vector2 (150, 150);

    private Vector2 firstTouchPos, endTouchPos;
       
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch1 = Input.GetTouch(0);

            // При нажатии находим координаты точки касания и находим дистанцию между двумя касаниями
            if (touch1.phase == TouchPhase.Began)
            {
                firstTouchPos = new Vector2 (touch1.position.x, touch1.position.y);

                distance = Vector2.Distance (firstTouchPos, secondTouchPos);
            }

            // При окончании нажатия находим новые координаты точки касания и новую дистанцию между двумя касаниями
            if (touch1.phase == TouchPhase.Ended)
            {
                endTouchPos = new Vector2(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y);

                distanceTemp = Vector2.Distance (firstTouchPos, endTouchPos);               

                if (distanceTemp > distance && distanceTemp >= distance + distance/10)
                {
                    Debug.Log("Жест увеличения");
                }
            }
        }
    }
}
