using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MyCharacter : MonoBehaviour
{
    public bool movable = false;
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
        if (movable)
        {
            speed.x = -2;
        }
        controller.SimpleMove(speed);
    }

    public void CharacterWalk()
    {
        movable = true;
        GetComponent<Animation>().Play("walk");
    }

    public void CharacterStop() { 
        movable = false;
        GetComponent<Animation>().Play("idle");
    }
}
