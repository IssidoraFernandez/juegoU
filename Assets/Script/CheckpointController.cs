using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public static CheckpointController instance;

    public Checkpoint[] checkpoints;

    public Vector3 spawnPoint;


    private void Start()
    {
        checkpoints = FindObjectsOfType<Checkpoint>();

        //establecer el spawnpoint inicial
        spawnPoint = movPersonaje.instance.transform.position;
    }


    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //esta funcion itera por todos los checkpoints y los desactiva
    public void DeactivateCheckpoints()
    {
        for (int i = 0; i < checkpoints.Length; i++)
        {
            checkpoints[i].ResetCheckpoint();
        }
    }

    //esta funcion se encarga de cambiar el spawnpoint
    public void SetSpawnPoint(Vector3 newSpawnPoint)
    {
        spawnPoint = newSpawnPoint;
    }
}
