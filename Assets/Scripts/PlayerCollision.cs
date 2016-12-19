using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Special Egg")
        {
            Destroy(coll.gameObject);
            Eggs.specialEggs += 1;
        } 
    }
}
