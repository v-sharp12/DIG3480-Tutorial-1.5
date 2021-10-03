using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quickclose : MonoBehaviour
{    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
