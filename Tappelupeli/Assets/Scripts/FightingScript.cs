using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingScript : MonoBehaviour
{
    // onko hyökkäys käynnissä
	bool attacking = false;
	// ajastin hyökkäyksen kestolle
	float coolDown = 0.25f;
	float coolDownTimer = 0.0f;
	// animaattori
	public Animator myAnimator;
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// lyöminen
        if (!attacking && Input.GetButtonDown("Fire1"))
		{
			attacking = true;
			coolDownTimer = coolDown;
			Punch();
		}
		// iskun ajastimen pienentäminen
		if (coolDownTimer > 0)
		{
			coolDownTimer -= Time.deltaTime;
		}
		else
		{
			attacking = false;
		}
    }
	void Punch()
	{
		myAnimator.SetTrigger("Punch1");
	}
}
