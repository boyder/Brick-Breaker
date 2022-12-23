using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current mouse position in screen space
        Vector3 mousePosition = Input.mousePosition;

        // Convert the mouse position to world space
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Set the object's position to the mouse position
        Vector3 fixedPosition = mouseWorldPosition;
        fixedPosition.z = 0;
        fixedPosition.y = -4.2087f;
        //quick fix for racket not colliding with wall
        if(fixedPosition.x > 7.178)
        {
            fixedPosition.x = 7.178f;
        }
        else if(fixedPosition.x < -7.178)
        {
            fixedPosition.x = -7.178f;
        }
        
        transform.position = fixedPosition;
    }
}
