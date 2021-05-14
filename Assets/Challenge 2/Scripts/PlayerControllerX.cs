using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogLaunchCooldown = 0.0f; 

    // Update is called once per frame
    void Update()
    {
        //dog launch cooldown
        dogLaunchCooldown += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogLaunchCooldown > 1.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogLaunchCooldown = 0.0f;
        }
    }
}
