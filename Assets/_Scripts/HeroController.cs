using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour {
	// PRIVATE  INSTANCE VARIABLES
	private Animator _animator;
	private float _move;
	private float _jump;
	private bool _facingRight;
	private Transform _transform;


	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
		this._animator = gameObject.GetComponent<Animator> ();
		this._move = 0f;
		this._jump = 0f;
		this._facingRight = true;
	}
	
	// Update is called once per frame
	void Update () {
		this._move = Input.GetAxis ("Horizontal");
		this._jump = Input.GetAxis ("Vertical");
		Debug.Log (this._jump);
		if (this._move != 0) {
			if (this._move > 0) {
				this._facingRight = true;
				this._flip ();
			}
			if (this._move < 0) {
				this._facingRight = false;
				this._flip ();
			}

			// call the walk clip
			this._animator.SetInteger ("AnimState", 1);
		} else {
			
			// set default animation state to "idle"
			this._animator.SetInteger ("AnimState", 0);
		}

		if (this._jump > 0) {
			// call the "jump" clip
			this._animator.SetInteger ("AnimState", 2);
		}
	}

	// PRIVATE METHODS
	private void _flip() {
		if (this._facingRight) {
			this._transform.localScale = new Vector2 (1, 1);
		} else {
			this._transform.localScale = new Vector2 (-1, 1);
		}
	}
}
