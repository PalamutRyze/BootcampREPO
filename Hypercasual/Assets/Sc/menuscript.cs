using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript  : MonoBehaviour
{
   public void PlayButton()
   {
        SceneManager.LoadScene(1);

   }
    public void RepeatButton()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
