using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = Random.RandomRange(0,100);
        int y = Random.RandomRange(0,100);
        transform.position = new Vector3(x,y,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
