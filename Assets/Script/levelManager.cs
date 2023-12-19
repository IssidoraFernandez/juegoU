using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    public static levelManager instance;

    public float waitToRespawn;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnPlayer()
    {
        StartCoroutine(RespawnCo());

    }

    IEnumerator RespawnCo()
    {
        movPersonaje.instance.gameObject.SetActive(false);

        yield return new WaitForSeconds(waitToRespawn);

        movPersonaje.instance.gameObject.SetActive(true);
        movPersonaje.instance.transform.position = CheckpointController.instance.spawnPoint;

        PlayerHealth.instance.currentHealth = PlayerHealth.instance.maxHealth;
        
    }
}
