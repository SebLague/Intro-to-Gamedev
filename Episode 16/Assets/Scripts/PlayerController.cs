using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 7;
	public event System.Action OnPlayerDeath;

	float screenHalfWidthInWorldUnits;

	// Use this for initialization
	void Start () {

		float halfPlayerWidth = transform.localScale.x / 2f;
		screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize + halfPlayerWidth;
	
	}
	
	// Update is called once per frame
	void Update () {

		float inputX = Input.GetAxisRaw ("Horizontal");
		float velocity = inputX * speed;
		transform.Translate (Vector2.right * velocity * Time.deltaTime);

		if (transform.position.x < -screenHalfWidthInWorldUnits) {
			transform.position = new Vector2 (screenHalfWidthInWorldUnits, transform.position.y);
		}

		if (transform.position.x > screenHalfWidthInWorldUnits) {
			transform.position = new Vector2 (-screenHalfWidthInWorldUnits, transform.position.y);
		}

	}

	void OnTriggerEnter2D(Collider2D triggerCollider) {
		if (triggerCollider.tag == "Falling Block") {
			if (OnPlayerDeath != null) {
				OnPlayerDeath ();
			}
			Destroy (gameObject);
		}
	}
}
