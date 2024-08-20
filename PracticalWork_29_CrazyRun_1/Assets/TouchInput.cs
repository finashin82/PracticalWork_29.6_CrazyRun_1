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

            // ��� ������� ���������� �������������� ����������
            if (touch.phase == TouchPhase.Began )
            {
                startTapX = touch.position.x;
                startTapY = touch.position.y;
            }

            // ��� ��������� ������� ���������� � ���������� ������������
            if (touch.phase == TouchPhase.Ended)
            {
                if (Input.GetTouch(0).position.x - startTapX > 100 && Input.GetTouch(0).position.y - startTapY < 50) Debug.Log("����� ������");
            }
            
            // ���������� ���������. ���� �������� ���� �����, �� ������� ��� ��������������� ������������
            if (touch.deltaPosition.x < 0)
            {
                startTapX = touch.position.x;
                Debug.Log("����� ������");
            }   
        }
    }
}
