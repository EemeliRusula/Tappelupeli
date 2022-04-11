using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	float speed = 5.0f;
	float jumpForce = 6.0f;
	float horizontalMovement = 0.0f;
	// muuttuja pelihahmon rigidbodylle
	public Rigidbody2D MyRigidbody;
	public CircleCollider2D Feet;
	public LayerMask Ground;
	public Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// otetaan tieto liikkumisnäppäinten painamisesta
        horizontalMovement = Input.GetAxis("Horizontal");
		// Debug.Log(horizontalMovement)
		// jos painetaan hyppynappia, niin hypätään
		if (Input.GetButtonDown("Jump") && Feet.IsTouchingLayers(Ground))
		{
			// tehdään vektori hyppäykseen
			Vector2 jumpVector = new Vector2(0, jumpForce);
			// lisätään hyppyvektori rigidbodyyn impulssina
			MyRigidbody.AddForce(jumpVector, ForceMode2D.Impulse);
		}
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
