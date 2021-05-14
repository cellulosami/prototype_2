using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 20.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //keep the player inbounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }
        
        //move the player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontalInput, 0, verticalInput);
        move = move.normalized * Time.deltaTime * speed;
        transform.Translate(move);

        //launch banana
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        Debug.Log("Game Over (hit by animal)");
    }
}
