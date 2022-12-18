using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLogic : MonoBehaviour
{
    public AudioSource sound_source;
    public AudioClip sound;

    public float distance_to_coin;
    public float minimal_distance;
    public Transform character;

    public void SelfDestroy() 
    {
        sound_source.PlayOneShot(sound);
        Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance_to_coin = Vector3.Distance(transform.position, character.position);
        if (distance_to_coin <= minimal_distance) SelfDestroy();


    }
}
