using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScreen : MonoBehaviour
{
    public void Show(bool isOpen)
    {
        gameObject.SetActive(isOpen);
    }
}
