using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceButton : MonoBehaviour
{
    [SerializeField] private int numberPlace;
    [SerializeField] private SpriteRenderer sprite;

    private void OnMouseDown()
    {
        //�������� ���� � ����� ��������� ��������
        Debug.Log(222);
        sprite.color = Color.black;
    }
}
