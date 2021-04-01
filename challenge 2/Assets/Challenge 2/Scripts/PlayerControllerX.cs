using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeDelay = 1.0f;
    private float nextAction = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        //Time.Time
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextAction)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Debug.Log(Time.time);
            Debug.Log("Action has occured and is in cooldown");
            nextAction = Time.time + timeDelay;
        }
    }
}
