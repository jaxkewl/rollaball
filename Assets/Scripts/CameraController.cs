using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = this.transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //this updates runs after all the other updates are done
        //so now we know the camera position wont be updated until the player position has been updated
        this.transform.position = player.transform.position + offset;
    }
}
