using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

    [SerializeField]private GameObject _bullet;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        if(Eggs.ammo > 0 && SetBool.IsPlaying  == true)
        {
            Instantiate(_bullet, transform.position, Quaternion.identity);
            Eggs.ammo -= 1;
        }
    }
}
