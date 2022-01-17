using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppButtonInfo : MonoBehaviour
{
    public AppButtonType AppButtonType;
}

public enum AppButtonType
{
    Login,
    Problem,
    Settings,
    Logout,
    LogoutConfirm, //вынести
    Map,
    Call, //вынести
    ProblemClose,
    Eye //вынести
}
