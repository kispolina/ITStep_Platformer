using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : MonoBehaviour
{


    // флоат - формат дробової цифри
    public float keyboard_x, keyboard_y;
    public float move_speed;
    public float jump_force;

    public CharacterController character;

    public float gravity;
    public float gravity_mul;


    public bool is_grounded;


    void ReadFromGamepad() 
    {
        keyboard_x = Input.GetAxis("Horizontal");
        keyboard_y = Input.GetAxis("Vertical");
    }

    void ApplyGravity() 
    {
        if (is_grounded) 
        {
            if (Input.GetButtonDown("Jump")) gravity = jump_force; 
        }
        if (is_grounded==false)
        {
            gravity -= 9.8f * gravity_mul * Time.deltaTime;
        }
        Vector3 direction_and_speed = new Vector3(0, gravity, 0);
        character.Move(direction_and_speed);

    }

    void GroundCheck() 
    {
        var hitboxes_list = Physics.OverlapSphere(transform.position,character.radius+0.1f);
       

        is_grounded = hitboxes_list.Length>1;

        

    }


    void MoveCharacter()
    {
       ApplyGravity();
       Vector3 direction_and_speed = new Vector3(keyboard_x,0, keyboard_y)* move_speed * Time.deltaTime  ;
       character.Move(direction_and_speed);
      

    }
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        ReadFromGamepad();
        GroundCheck();
        MoveCharacter();

      
    }
}
