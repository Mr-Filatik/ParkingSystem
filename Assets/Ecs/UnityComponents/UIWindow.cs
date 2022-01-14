using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindow : MonoBehaviour
{
    public void Show(bool isOpen)
    {
        //change
        gameObject.SetActive(isOpen);
    }
}
