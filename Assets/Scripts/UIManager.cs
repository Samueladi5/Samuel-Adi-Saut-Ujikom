using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    // Update is called once per frame
    public void ExitGame()
    {
        Application.Quit();
    }
}
