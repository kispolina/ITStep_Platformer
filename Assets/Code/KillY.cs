using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillY : MonoBehaviour
{
	
	public GameObject respawn_point;
	public GameObject character;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(character.transform.position.y < transform.position.y) 
		{
			character.GetComponent<CharacterController>().enabled = false;
			character.transform.position = respawn_point.transform.position;
			character.GetComponent<CharacterController>().enabled = true;
    	
		}
	}
}
