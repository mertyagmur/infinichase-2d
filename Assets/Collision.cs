using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Enemy"){
            Debug.Log("Bumped into enemy!");
            FindObjectOfType<Player>().healthAmount -= 5;
        }
        else {
            Debug.Log("Bumped into static object!");
        }
    }
}
