using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI EggCounter;
    public TextMeshProUGUI ChickCounter;
    public TextMeshProUGUI RoosterCounter;
    public TextMeshProUGUI HenCounter;

    public static int eggCounter;
    public static int chickCounter;
    public static int roosterCounter;
    public static int henCounter;

    // List of possible spawn points
    public Transform spawnPoints;
    // Prefab of the egg to spawn
    public GameObject eggPrefab;
    // Delay in seconds before the egg spawns
    public static float timer;

    void Start()
    {

        Instantiate(eggPrefab, spawnPoints.position, spawnPoints.rotation);

    }


    void Update()
    {

        EggCounter.text = eggCounter.ToString();
        ChickCounter.text = chickCounter.ToString();
        RoosterCounter.text = roosterCounter.ToString();
        HenCounter.text = henCounter.ToString();
        timer += Time.deltaTime;
        Debug.Log(eggCounter);


    }

}
