using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    public GameObject Number;
    public bool isHighScore = true;
    void Start()
    {
        generateNumber(
            isHighScore ? GameControl.highScore : GameControl.score
        );
    }

    public void generateNumber(float number)
    {
        float spaceBetween = 50f;

        int length = number.ToString().Length;
        for (int i = 0; i < length; i++)
        {
            GameObject numberObject = Instantiate(Number, transform);
            numberObject.GetComponent<NumberSprite>().setNumber((int)number % 10);
            numberObject.transform.position = new Vector3(
                transform.position.x - spaceBetween * i,
                transform.position.y,
                transform.position.z
            );
            number /= 10;
        }
    }
}
