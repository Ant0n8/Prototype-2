using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 35.0f;
    private float bottomBoundary = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroys object when out of specified boundaries
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < bottomBoundary)
        {
            Debug.Log("Animal Passed");
            Destroy(gameObject);
        }
    }
}