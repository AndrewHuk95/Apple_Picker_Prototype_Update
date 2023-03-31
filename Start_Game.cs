using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Game : MonoBehaviour
{
   
   
   
   public void MainMenu()
   {
        SceneManager.LoadScene("FirstScene");
   }
   public void ExitButton()
   {
        Application.Quit();
   }
   
}
