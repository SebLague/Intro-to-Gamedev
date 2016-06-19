using UnityEngine;
using System.Collections;

public class FallingBlock : MonoBehaviour {

	float speed = 7;


	void Update () {
		transform.Translate (Vector3.down * speed * Time.deltaTime, Space.Self);
	}
}
