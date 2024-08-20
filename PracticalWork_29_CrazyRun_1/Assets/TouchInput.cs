using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    Touch touch;
    
    private float startTapX, startTapY, startTemp;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            // При нажатии определяем первоначальные координаты
            if (touch.phase == TouchPhase.Began )
            {
                startTapX = touch.position.x;
                startTapY = touch.position.y;
            }

            // При окончании нажатия сравниваем с последними координатами
            if (touch.phase == TouchPhase.Ended)
            {
                if (Input.GetTouch(0).position.x - startTapX > 100 && Input.GetTouch(0).position.y - startTapY < 50) Debug.Log("Свайп вправо");
            }
            
            // Повышенная сложность. Если движение идет влево, то считать это первоначальными координатами
            if (touch.deltaPosition.x < 0)
            {
                startTapX = touch.position.x;
                Debug.Log("Новое начало");
            }   
        }
    }
}
