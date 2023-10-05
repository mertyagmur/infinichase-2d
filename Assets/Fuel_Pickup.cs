using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel_Pickup : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("Fuel picked up");
            gameObject.SetActive(false);
            FindObjectOfType<Player>().fuelAmount += 1000;
            FindObjectOfType<ItemSpawner>().fuelCounter -= 1;
        }
    }
}
