using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {
	
    void Start()
    {
        Destroy(this.gameObject, 3f);
    }
}
