using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesGenerator : MonoBehaviour
{
    public GameObject pipePrefab;
    private bool startedGenerating = false;
    IEnumerator generator()
    {
        while (true)
        {
            float yRandom = Random.Range(-2f, -8f);
            GameObject newPipe = Instantiate(pipePrefab, new Vector3(10, yRandom, 0), Quaternion.identity);
            newPipe.transform.parent = transform;
            yield return new WaitForSeconds(2);
        }
    }


    void FixedUpdate()
    {
        if (GameControl.isStarted && !GameControl.isGameOver && !startedGenerating)
        {
            StartCoroutine(generator());
            startedGenerating = true;
        }
    }
}
