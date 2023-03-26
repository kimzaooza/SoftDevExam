using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemB : MonoBehaviour
{
    private SpawnManager spawnManager;

    public void Awake()
    {
        spawnManager = GameObject.FindWithTag("SpawnManager").GetComponent<SpawnManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            spawnManager.DespawnGhostServerRpc();
        }
    }
}
