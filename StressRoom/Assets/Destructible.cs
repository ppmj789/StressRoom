using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

    public GameObject destroyedVersion;

    void Start()
    {

    }

    void OnCollisionEnter(Collision Collection)
    {
        if(Collection.gameObject.name == "MainCharacter")
        {
            //SoundScript.instance.PlaySound();
            //GameObject.Find("Pistol_01_Mountain_Tail_SFX").GetComponent<AudioSource>().Play();
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    
	void OnMouseDown()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    
}

