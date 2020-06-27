using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject player;
    Vector3 initialPosition;

    void Start()
    {
        initialPosition = player.transform.position;
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            player.transform.position = initialPosition;
        }
    }
}
