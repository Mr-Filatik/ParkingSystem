using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoSceneController : MonoBehaviour
{
    [SerializeField, Range(0, 5)] private float timeStartScreen = 0.5f;

    private IEnumerator Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.orientation = ScreenOrientation.Portrait;
        Application.targetFrameRate = 60;
        Resources.UnloadUnusedAssets();

        yield return new WaitForSeconds(timeStartScreen); 
        SceneManager.LoadScene(1);
    }
}
