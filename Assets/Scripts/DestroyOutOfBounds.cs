using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperBound = 30.0f;
    private float lowerBound = -10.0f;
    private float rightBound = 27.0f;
    private float leftBound = -27.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if an object moves outside of the player's view, remove it
        //if an animal gets by the player, game over
        if (transform.position.z > upperBound ||
            transform.position.z < lowerBound ||
            transform.position.x > rightBound ||
            transform.position.x < leftBound) {
                
            Destroy(gameObject);
        }
    }
}
