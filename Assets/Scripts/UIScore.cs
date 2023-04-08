using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    public GameObject gold;
    public GameObject silver;
    public GameObject bronze;
    public GameObject iron;
    public Transform parentCard;
    public bool isCurrentMedal = true;
    // Start is called before the first frame update
    void Start()
    {
        GameObject medal = getMedal(
            isCurrentMedal ? GameControl.score : GameControl.highScore
        );

        if (medal)
        {
            Instantiate(medal, parentCard);
        }
    }

    private GameObject getMedal(int score)
    {
        if (score >= 50)
        {
            return gold;
        }
        else if (score >= 25)
        {
            return silver;
        }
        else if (score >= 15)
        {
            return bronze;
        }
        else if (score >= 5)
        {
            return iron;
        }
        else
        {
            return null;
        }
    }
}
