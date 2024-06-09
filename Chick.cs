using UnityEngine;
using System.Collections;
using System.Threading;

public class Chick : MonoBehaviour
{
    private float Timer2;
    public GameObject henPrefab;
    public GameObject roosterPrefab;

    void Start()
    {
        Timer2 = GameManager.timer;
        GameManager.timer++;

    }

    private void Update()
    {
        if (Timer2 > 21f)
        {
            StartCoroutine(Grow());
        }
        else
        {
            StartCoroutine(SpawnHen());
        }
    }
    IEnumerator Grow()
    {
        yield return new WaitForSeconds(10f);
        if (Random.value > 0.5f)
        {
            GameManager.chickCounter++;
            Instantiate(henPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);  // Destroy the chick
            GameManager.chickCounter--;
        }
        else
        {
            GameManager.chickCounter++;
            Instantiate(roosterPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);  // Destroy the chick
            GameManager.chickCounter--;
        }
    }

    IEnumerator SpawnHen()
    {
        GameManager.chickCounter++;
        yield return new WaitForSeconds(10f);
        Instantiate(henPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        GameManager.chickCounter--;

    }
}