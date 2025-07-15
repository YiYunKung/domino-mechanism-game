using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCollisionEvent : MonoBehaviour
{
    public MyCharacter character;
    bool SwitchEnable = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (SwitchEnable == true)
        {
            character.CharacterWalk();
            SwitchEnable = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
