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
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!attacking)
		{
			attacking = true;
			coolDownTimer = coolDown;
			Punch();
		}
    }
	void Punch()
	{
		
	}
}
