using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {

    [SerializeField]private int _dropChance;

    [SerializeField]private GameObject _droppedEgg;

    void OnTriggerEnter2D(Collider2D coll)
    {
        Destroy(this.gameObject);
        Destroy(coll.gameObject); 
        DropEgg();
    }

    void DropEgg()
    {
        int chance = Random.Range(0, _dropChance + 1);
        if(chance == _dropChance)
        {
            Instantiate(_droppedEgg, transform.position, Quaternion.identity);
        }
    }
}
