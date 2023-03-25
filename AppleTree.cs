using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header ("Set in Inspector")]
    public GameObject[] prefabs = new GameObject [3] ;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirections = 0.1f;
    public float secondBetweenAplleDrops = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
    void FixedUpdate() 
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
        
    }
    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(prefabs[Random.Range(0, prefabs.Length)]);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondBetweenAplleDrops);
    }
}