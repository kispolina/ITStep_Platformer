using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllSystem : MonoBehaviour
{
    public Transform character_camera;
    public Transform character_info;

    public Transform aspect_point;
    public float distance_to_aspect_point;
    public float minimal_distance;
    public float camera_fly_speed = 1f;



    // 2) Плавне пересування до вказаної координати


    public void RotateToCharacter() 
    {
        character_camera.LookAt(character_info.position);
    }
    public void MoveToAspectPoint()
    {
        distance_to_aspect_point = Vector3.Distance(character_camera.position, aspect_point.position);
        if (distance_to_aspect_point > minimal_distance) 
        {
            Vector3 direction_to_move = (aspect_point.position - character_camera.position).normalized;   //
            character_camera.position += (direction_to_move * camera_fly_speed) /100;                                                                                     //    
        }


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateToCharacter();
        MoveToAspectPoint();

    }
    
}
