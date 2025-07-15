using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushDominoes : MonoBehaviour
{
    public GameObject dominoeStart;
    public float force = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            dominoeStart.GetComponent<Rigidbody>().AddForce(force, 0, 0, ForceMode.Impulse);
        }
    }
}
