using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene("Level");
    }

    public void OnInstructionButtonPressed()
    {
        SceneManager.LoadScene("Instruction");
    }

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnNextButtonPressed()
    {
        SceneManager.LoadScene("End");
    }

}

