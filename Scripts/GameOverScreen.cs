using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void ExitButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
