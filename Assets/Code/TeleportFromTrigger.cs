using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportFromTrigger : MonoBehaviour
{

    public GameObject point_to_spawn;






    void OnTriggerEnter(Collider touch_object) 
    {
        touch_object.transform.position = point_to_spawn.transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
