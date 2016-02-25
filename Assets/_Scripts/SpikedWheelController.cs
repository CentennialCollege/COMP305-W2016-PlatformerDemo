using UnityEngine;
using System.Collections;

public class SpikedWheelController : MonoBehaviour {
	// PRIVATE INSTANCE VARIABLES
	private Transform _transform;


	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		this._transform.Rotate (0, 0, -3f);

	}
}
