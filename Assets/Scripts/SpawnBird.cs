using UnityEngine;
using System.Collections;

public class SpawnBird : MonoBehaviour {

    [SerializeField]private GameObject[] _birds;
    private GameObject _randomBird;

	void Start () {
        InvokeRepeating("Spawn", 0.5f, 2f);
	}

    void Spawn()
    {
        if (SetBool.IsPlaying == true)
        {
            _randomBird = _birds[Random.Range(0, _birds.Length)];
            Instantiate(_randomBird, transform.position, transform.rotation);
        }
    }
}
