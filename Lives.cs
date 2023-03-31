using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public Text lives;
    // Update is called once per frame
    void Update()
    {
        GameObject livesNow = GameObject.Find("Lives");
        lives = livesNow.GetComponent<Text>();
        if (ApplePicker.numBaskets == 1)
        {
            lives.text = "Lives: LAST!!!be careful!";
            return; 
        }
        lives.text = "Lives: "+ ApplePicker.numBaskets.ToString();
        if (ApplePicker.numBaskets == 0)
        {
            SceneManager.LoadScene("GameOverScene");
            ApplePicker.numBaskets = 3;
        }
    }
}
