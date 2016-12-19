using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    private int _bulletSpeed = 15;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * _bulletSpeed * Time.deltaTime);
	}
}
