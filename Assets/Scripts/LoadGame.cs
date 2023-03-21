using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{

    // Defined by me Temproraly
    public void OnPlayClick()
    {
        SceneManager.LoadScene("Game");
    }
    public void onBack()
    {
        SceneManager.LoadScene("Menu");
    }
}
