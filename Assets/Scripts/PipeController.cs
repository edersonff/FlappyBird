using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    private GameObject player;
    private bool isPassed = false;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if (transform.position.x < -10.1f)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < player.transform.position.x && !isPassed)
        {
            isPassed = true;
            GameControl.score++;
        }
    }
}
