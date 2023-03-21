using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Add this line to be able to restart the scene

public class playerstats : MonoBehaviour
{
    static int potionred05counter = 0;
    static float Healthy;
    static float Healthymax = 100;
    public Slider HealthBar;
    private void Start()
    {
        HealthBar.maxValue = Healthymax;
        HealthBar.minValue = 0;
        Healthy = Healthymax;
    }
     void Update()
    {
        HealthBar.value = Healthy;
/*
        if (transform.position.x > 38 && transform.position.x < 44)
        {
            if (transform.position.y > 0 && transform.position.y < 5)
            {
                if (transform.position.z > 0 && transform.position.z < 6)
                {
                    // Vector3 newPosition = new Vector3(1012.58f, 501.33f, 4.44f);
                    Vector3 newPosition = new Vector3(100, 100, 100);

                    transform.position = new Vector3(100, 100, 100);
                    UnityEngine.Debug.Log("a");
                }
            }
        }
        */
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Damage(10f); // Call the Damage function and pass in a value of 10
        }
        if (Healthy <= 0f)
        {
            RestartGame("SampleScene"); // Call the RestartGame function
        }


      /*  if (transform.position.x > 154 && transform.position.x < 156)
        {
            if (transform.position.y > 1 && transform.position.y < 2)
            {
                if (transform.position.z > 34 && transform.position.z < 36)
                {
                    Vector3 newPosition = new Vector3(47.6f, 1.77f, 4.44f);
                    transform.position = newPosition;

                }
            }
        }*/
        // Find the game object representing the portal
        GameObject portalA = GameObject.Find("PortalTestA");

        // Check if the portal object was found successfully
        if (portalA != null)
        {
            // If the '1' key is pressed, move the portal to position (100, 100, 100)
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                portalA.transform.position = new Vector3(transform.position.x, 3.4f, transform.position.z);
            }
        }
        GameObject portalB = GameObject.Find("PortalTestB");

        // Check if the portal object was found successfully
        if (portalB != null)
        {
            // If the '1' key is pressed, move the portal to position (100, 100, 100)
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                portalB.transform.position = new Vector3(transform.position.x, 3.4f, transform.position.z);
            }
        }
        /*  if (transform.position.z > 20)
          {
              Heal(10f); // Call the Heal function and pass in a value of 10
              GameObject cube = GameObject.Find("BoxA"); // Find the game object named "CUBA"
              Destroy(cube); // Destroy the "CUBA" game object
          }
          */

        if (transform.position.z > 29 && transform.position.z < 31 && potionred05counter == 0)
        {
            if (transform.position.y > 0 && transform.position.y < 2)
            {
                if (transform.position.x > 40 && transform.position.x < 42)
                {
                    potionred05counter++;
                    Heal(10f); // Call the Heal function and pass in a value of 10
                    GameObject cube = GameObject.Find("Bottle_Health1"); // Find the game object named "CUBA"
                    Destroy(cube); // Destroy the "CUBA" game object
                }
            }

        }
    }

    void Damage(float damageAmount)
    {
        Healthy -= damageAmount; // Subtract the damage amount from the current health value
    }
    void RestartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName); // Load the specified scene    }
    }



    void Heal(float healAmount)
    {
        Healthy += healAmount; // Add the heal amount to the current health value
        if (Healthy > Healthymax) // Ensure that the health value doesn't exceed the maximum
        {
            Healthy = Healthymax;
        }
    }





}
