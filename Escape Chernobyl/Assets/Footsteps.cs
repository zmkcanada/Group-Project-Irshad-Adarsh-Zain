using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footstepsSound;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.D))){
            footstepsSound.enabled = true;
        }
        else
        {
            footstepsSound.enabled = false;
        }
    }
}
