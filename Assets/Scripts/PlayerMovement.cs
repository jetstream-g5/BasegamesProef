using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]private float speed = 6.0F;
    private Vector3 moveDirection = Vector3.zero;

    private SpriteRenderer _sp;

    // Use this for initialization
    void Start () {
        _sp = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        if (moveDirection.x > 0)
        {
            FlipSprite(false);
        }
        else if(moveDirection.x < 0)
        {
            FlipSprite(true);
        }

        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

    void FlipSprite(bool flip)
    {
        _sp.flipX = flip;
    }
}
