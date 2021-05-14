using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Animal") {
            GameObject hit = other.gameObject;
            Health health = hit.GetComponent<Health>();
            
            if(health != null) {
                health.TakeDamage(5);
            }
            Destroy(gameObject);
        }
    }
}
