using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public GameObject chickPrefab;
    private int EggCounter;

    void Start()
    {
        EggCounter = GameManager.eggCounter;
        GameManager.eggCounter++;


        StartCoroutine(Hatch());
    }
    private void Update()
    {
    }

    IEnumerator Hatch()
    {

        yield return new WaitForSeconds(10f);
        GameObject chick = Instantiate(chickPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);  // Destroy the egg
        GameManager.eggCounter--;
    }
}