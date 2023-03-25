using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApplePicker : MonoBehaviour
{
    [Header ("Set in Inspector")]
    public GameObject basketPrefab;
    public Text lives;
    public int numBaskets = 3;
    public float basketBottomY = -10f;
    public float basketSpacingY = 2f;
    public float basketPosZ = -8f;

    public List<GameObject> basketList;

    void Start()
    {
        

        if (numBaskets != 0)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.z = basketPosZ;
            pos.y = basketBottomY;
            tBasketGO.transform.position = pos;
        }
        // basketList = new List<GameObject>();
        // for (int i = 0; i < numBaskets; i++)
        // {
        //     GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
        //     Vector3 pos = Vector3.zero;
        //     pos.z = basketPosZ;
        //     pos.y = basketBottomY + (basketSpacingY * i);
        //     tBasketGO.transform.position = pos;
        //     basketList.Add(tBasketGO);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AppleDestroyed()
    {
        
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject  tGo in tAppleArray)
        {
            Destroy(tGo);
        }
        
        numBaskets -= 1;
        if (numBaskets == 0)
        {
            SceneManager.LoadScene("_Scene_0");
            return;
        }
        
        GameObject livesNow = GameObject.Find("Lives");
        lives = livesNow.GetComponent<Text>();
        if (numBaskets == 1)
        {
            lives.text = "Lives: LAST!!!be careful!";
            return; 
        }
        lives.text = "Lives: "+ numBaskets.ToString();
        

        // int basketIndex = basketList.Count-1;
        // GameObject tBasketGO = basketList[basketIndex];
        // basketList.RemoveAt(basketIndex);
        // Destroy(tBasketGO);
        // if (basketList.Count == 0)
        // {
        //     SceneManager.LoadScene("_Scene_0");
        // }
    }
}