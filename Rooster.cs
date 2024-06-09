using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyRooster());
        GameManager.roosterCounter++;
    }

    // Update is called once per frame

    IEnumerator DestroyRooster()
    {
        yield return new WaitForSeconds(40f);
        Destroy(gameObject);
        GameManager.roosterCounter--;

    }
}
