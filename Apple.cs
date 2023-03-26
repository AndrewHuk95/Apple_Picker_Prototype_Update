using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [Header ("Set in Inspector")]
    public float bottomY = 0f;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            // ApplePicker liveDell = Camera.main.GetComponent<ApplePicker>();
            // liveDell.Lives();
            Destroy(this.gameObject);
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            apScript.AppleDestroyed();
            ApplePicker.numBaskets -= 1;
        }
    }
}