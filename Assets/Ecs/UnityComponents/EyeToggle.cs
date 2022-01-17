using Leopotam.Ecs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeToggle : MonoBehaviour
{
    private bool state;
    [SerializeField] private Sprite spriteOpen = null;
    [SerializeField] private Sprite spriteClose = null;
    [SerializeField] private InputField inputField = null;

    private void OnEnable()
    {
        state = false;
        gameObject.GetComponent<Image>().sprite = spriteClose;
        inputField.contentType = InputField.ContentType.Password;
        inputField.DeactivateInputField();
        inputField.ActivateInputField();
    }

    public void ChangeState()
    {
        state = !state;
        if (state)
        {
            gameObject.GetComponent<Image>().sprite = spriteOpen;
            inputField.contentType = InputField.ContentType.Standard;
            inputField.DeactivateInputField();
            inputField.ActivateInputField();
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = spriteClose;
            inputField.contentType = InputField.ContentType.Password;
            inputField.DeactivateInputField();
            inputField.ActivateInputField();
        }
    }
}
