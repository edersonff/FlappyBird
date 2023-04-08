using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberSprite : MonoBehaviour
{

    public void setNumber(int number)
    {
        Animator animator = GetComponent<Animator>();
        animator.Play("Numbers", 0, number / 10f);
    }
}
