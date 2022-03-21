using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	float speed = 5.0f;
	float horizontalMovement = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// otetaan tieto liikkumisnäppäinten painamisesta
        horizontalMovement = Input.GetAxis("Horizontal");
		Debug.Log(horizontalMovement);
    }
}
