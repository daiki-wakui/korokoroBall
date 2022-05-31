using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text textComponet;
    public AudioSource audioCoinSource;

    private int coinCount;

    private void Start()
    {
        coinCount = 0;
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
    }

    public void AddCoinCount()
    {
        audioCoinSource.Play();
        coinCount = coinCount + 1;
        Debug.Log("CoinCount:" + coinCount.ToString());
        textComponet.text = "Coin : " + coinCount.ToString();
    }

    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}
