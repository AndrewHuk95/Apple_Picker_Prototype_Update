using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormDell : MonoBehaviour
{
    
    void Update()
    {
        if (gameObject.transform.position.y < -20f )
        {
            Destroy(this.gameObject);
        }
    }
}
