using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	float speed = 5.0f;
	float horizontalMovement = 0.0f;
	// muuttuja pelihahmon rigidbodylle
	public Rigidbody2D MyRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// otetaan tieto liikkumisnäppäinten painamisesta
        horizontalMovement = Input.GetAxis("Horizontal");
		// Debug.Log(horizontalMovement);
    }
	void FixedUpdate() 
	{
		// haetaan näppäimistöltä tiedot miten liike sivusuunnassa pitää mennä
		float xVelocity = speed * horizontalMovement;
		// pystysuunnan liike haetaan rigidbodysta
		float yVelocity = MyRigidbody.velocity.y;
		// asetetaan nämä uudeksi liikevektoriksi
		MyRigidbody.velocity = new Vector2(xVelocity, yVelocity);
	}
}
