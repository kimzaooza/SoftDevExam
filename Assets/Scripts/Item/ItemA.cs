using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;

public class ItemA : MonoBehaviour
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
            spawnManager.SpawnNotPlayerPrefabsServerRpc(2, new Vector3(11.47f, -19.39f, 0f));
        }
    }

    
}
