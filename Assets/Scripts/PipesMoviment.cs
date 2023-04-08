using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMoviment : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (!GameControl.isRunning())
        {
            return;
        }
        transform.position += Vector3.left * 0.05f;
    }
}
