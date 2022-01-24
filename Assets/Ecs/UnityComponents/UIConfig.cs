using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIConfig : MonoBehaviour
{
    [Header("InputFields")]
    public InputField inputLogin = null;
    public InputField inputPassword = null;

    [Header("Screens")]
    public UIScreen LoginScreen = null;
    public UIScreen MapScreen = null;
    public UIScreen SettingsScreen = null;
    public UIScreen LogoutScreen = null;
    public UIScreen ProblemScreen = null;

    [Header("Backgrounds")]
    public UIBackground UIBackground = null;

    [Header("Windows")]
    public UIWindow InfoWindow = null;
    public UIWindow BookingWindow = null;
}
