using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson29Temp : MonoBehaviour
{
    Touch touch;
    /*
    [SerializeField] private Rigidbody rb;

    [SerializeField] private float speed;

    Vector3 force;

    private float startTimer;
    */    

    void Update()
    {
        if (Input.touchCount > 0)
        {
            //touch = Input.GetTouch(0);

            //force = new Vector3(touch.position.x, 0, touch.position.y);

            //rb.AddForce(force * speed);

            //if (touch.deltaPosition.x > 0) Debug.Log("������");
            //if (touch.deltaPosition.x < 0) Debug.Log("�����");

            /* �������� �� ������ �������
            if (touch.phase == TouchPhase.Began) 
            {
                startTimer = Time.time;

                Debug.Log("���");
            }

            if (touch.phase == TouchPhase.Ended && Time.time - startTimer > 2)
            {
                Debug.Log("������ �������");
            }
            */

            /*
            for (int i = 0; i< Input.touches.Length; i++)
            {
                Debug.Log("��� ������� ����� " + i + " � �������� " + Input.touches[i]);
            }
            */
        }
    }
}
