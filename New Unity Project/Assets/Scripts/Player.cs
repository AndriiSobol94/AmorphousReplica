using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const float speedMultiplier = 3;

    private float horizontalSpeed = 0;
    private float verticalSpeed = 0;

    Rigidbody RigidbodyComponent;

    // Start is called before the first frame update
    void Start()
    {
        RigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed");
        }
        horizontalSpeed = Input.GetAxis("Horizontal");
        Debug.Log(horizontalSpeed);
        verticalSpeed = Input.GetAxis("Vertical");
        Debug.Log(verticalSpeed);
    }

    private void FixedUpdate()
    {
        RigidbodyComponent.velocity = new Vector3(horizontalSpeed, 0, verticalSpeed) * speedMultiplier;
    }
}
