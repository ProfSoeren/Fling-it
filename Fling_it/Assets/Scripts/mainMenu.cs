using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;
    public void PlayGame()
    {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));  
    }

    public void RestartGame()
    {
        StartCoroutine(LoadLevel(1));
    }

    public void Menu()
    {
        StartCoroutine(LoadLevel(0));
    }


    IEnumerator LoadLevel(int LevelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(LevelIndex);
    }
}
