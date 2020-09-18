using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //multiplied by deltaTime in order to make it per second
        // rather than per frame
        this.transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * 2);
    }
}
