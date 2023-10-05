using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repair_Pickup : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("Repair picked up");
            gameObject.SetActive(false);
            FindObjectOfType<Player>().healthAmount += 10;
            FindObjectOfType<ItemSpawner>().healthCounter -= 1;
        }
    }
}
