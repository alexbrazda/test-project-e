using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    private bool isCursorLocked;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        isCursorLocked = true;
    }


    void Update()
    {
        // Lock and unlock the cursor with the M key
        if (Input.GetKeyDown(KeyCode.M)) 
            if (isCursorLocked)
            {
                Cursor.lockState = CursorLockMode.None;
                isCursorLocked = false;
                Debug.Log(isCursorLocked);
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                isCursorLocked = true;
                Debug.Log(isCursorLocked);
            }
    }
}
