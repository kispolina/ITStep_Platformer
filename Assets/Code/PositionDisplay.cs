using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionDisplay : MonoBehaviour
{
	
	public Transform position_display;

	public Vector3 my_custom_position; 
	
	public MeshRenderer show_model;
	
	public float x;
	
    // Start is called before the first frame update
    void Start()
    {
	
	
    }

    // Update is called once per frame
    void Update()
    {
		
		x=Time.deltaTime+x;
		
		if(((int)x) %2==0)
		{
			print("!!!!");
			show_model.enabled=false;
		}       
		else
		{
			print("??");			
			show_model.enabled=true;
		}
    }
}
