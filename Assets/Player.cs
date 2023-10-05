using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200;
    [SerializeField] public float moveSpeed = 15;

    [SerializeField] private Text fuelMeter;
    [SerializeField] public int fuelAmount;

    [SerializeField] private Text healthMeter;
    [SerializeField] public int healthAmount;

    public GameOverScreen GameOverScreen;

    void Start()
    {
        fuelAmount = 10000;
        healthAmount = 100;
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

        fuelMeter.text = "Fuel: " + (fuelAmount/100).ToString();
        healthMeter.text = "Health: " + healthAmount.ToString();

        if (Input.GetKey("up") | Input.GetKey("down")) {
                StartCoroutine(BurnFuel());
            }

        if (fuelAmount <= 0 | healthAmount <= 0) {
            GameOverScreen.Setup(FindObjectOfType<ScoreCounter>().score);
        }
    }

    private IEnumerator BurnFuel() {
        for (int i = fuelAmount; i >= 1; i--){
            fuelAmount -= 1;
            yield return new WaitForSeconds(0.01f);

            if (!Input.GetKey("up") | !Input.GetKey("down")) {
                break;
            }
        }
    }
}
