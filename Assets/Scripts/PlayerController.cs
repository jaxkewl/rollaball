using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 0.0f;
    public TextMeshProUGUI countText;
    public GameObject winTextObj;       //only need to disable and enable the text, so you just need gameobj reference
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObj.SetActive(false);
    }



    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 11)
        {
            winTextObj.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(speed * movementX, 0.0f, speed * movementY), ForceMode.Acceleration);
    }

    private void OnTriggerEnter(Collider other)
    {
        //this function will the contact between the player game object and
        //the pickup game objects without actually creating a physical collision
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
        
    }
}
