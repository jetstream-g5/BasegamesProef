using UnityEngine;
using System.Collections;

public class MoveBird : MonoBehaviour {

    [SerializeField]private float _speed;

	void Update () {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);
	}
}
