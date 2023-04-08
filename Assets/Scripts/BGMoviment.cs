using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMoviment : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (!GameControl.isRunning())
        {
            return;
        }
        transform.position += Vector3.left * 0.02f;
        if (transform.position.x <= -22.4)
        {
            transform.position = new Vector3(0f, transform.position.y, transform.position.z);
        }
    }
}
