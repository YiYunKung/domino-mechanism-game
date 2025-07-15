using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSimpleMove : MonoBehaviour
{
    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 speed = new Vector3(0, 0, 0);
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.A))
                speed.x = 5;
        }
        controller.SimpleMove(speed);
    }
}
