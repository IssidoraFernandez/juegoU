using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class damagePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           PlayerHealth.instance.dealDamage();
        }
    }
}
