using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverControl : MonoBehaviour
{
    private GameControl gameControl;
    private bool preventClick = true;

    // Start is called before the first frame update
    void Start()
    {
        gameControl = GameObject.Find("GameControl").GetComponent<GameControl>();

        StartCoroutine(waitForClick());
    }

    private IEnumerator waitForClick()
    {
        yield return new WaitForSeconds(0.5f);
        preventClick = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !preventClick)
        {
            gameControl.onRestart();
        }
    }
}
