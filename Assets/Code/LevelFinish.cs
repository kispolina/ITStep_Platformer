using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
	public GameObject character;
	public float distance_to_player;
	public float minimal_distance; 
	
	public string level_name; 
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		distance_to_player = Vector3.Distance( character.transform.position, transform.position   );
		if(distance_to_player<minimal_distance)
		{
			SceneManager.LoadScene(level_name);
			//Перех1д на новий р1вень
		}
        
    }
}
