using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorToogleTriggerZone : MonoBehaviour
{

    public Animator doors_to_switch;

    
    void OnTriggerEnter()
    {
        doors_to_switch.enabled = true;
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
