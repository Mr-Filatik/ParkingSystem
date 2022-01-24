using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBackground : MonoBehaviour
{
    public void Show(bool isOpen)
    {
        gameObject.SetActive(isOpen);
    }
}
