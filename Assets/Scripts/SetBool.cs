using UnityEngine;
using System.Collections;

public class SetBool : MonoBehaviour {

    private Animator _animator;
    public static bool IsPlaying = true;

	// Use this for initialization
	void Start () {
        _animator = GetComponent<Animator>();
	}
	
    public void OpenAndClose()
    {
        bool animBool = _animator.GetBool("IsOpen");   
        _animator.SetBool("IsOpen", !animBool);
        IsPlaying = animBool;
    }
}
