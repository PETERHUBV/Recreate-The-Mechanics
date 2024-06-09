using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : MonoBehaviour
{
    public GameObject EggPrefab;
    void Start()
    {
        StartCoroutine(LayEggs());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator LayEggs()
    {
        GameManager.henCounter++;
        yield return new WaitForSeconds(30f);
        int random = Random.Range(2, 9);
        for (int i = 0; i < random; i++)
        {
            Instantiate(EggPrefab, transform.position, transform.rotation);
        }

        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
        GameManager.henCounter--;
    }
}
