using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public float speed = 10.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 modified = new Vector3 (0, 0, 0);

//		RaycastHit hit = new RaycastHit ();
//		Ray ray = new Ray ();
//		ray = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 1.0f));
//		if (Physics.Raycast (ray, out hit, 100)) {
//
//			Debug.Log (hit.collider.gameObject.GetComponent<Transform>());
//		}


//		Debug.Log (transform.localRotation.x);



		if (Vector3.Angle(transform.forward, Vector3.forward) < 90) {
			Debug.Log ("turn");
			modified = transform.forward;
			//transform.Translate(transform.forward * Time.deltaTime * speed, Space.World);
		}

		transform.Translate((Vector3.forward + modified)* Time.deltaTime * speed, null);
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.collider.CompareTag("Death"))
			Respawn();
	}

	void Respawn(){
		transform.position = Vector3.zero;
	}

}
