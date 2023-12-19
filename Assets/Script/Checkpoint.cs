using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public SpriteRenderer spriteR;

    public Sprite checkOn, checkOff;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CheckpointController.instance.DeactivateCheckpoints();
            spriteR.sprite = checkOn;
            CheckpointController.instance.SetSpawnPoint(transform.position);
        }
    }

    void Update()
    {
        
    }

    public void ResetCheckpoint()
    {
        spriteR.sprite = checkOff;
    }
}
