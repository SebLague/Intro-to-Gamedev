using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	public Transform sphereTransform;

	// Use this for initialization
	void Start () {
		sphereTransform.parent = transform;
		sphereTransform.localScale = Vector3.one * 2;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * 180, Space.World);
		transform.Translate (Vector3.forward * Time.deltaTime * 7, Space.World);

		if (Input.GetKeyDown (KeyCode.Space)) {
			sphereTransform.localPosition = Vector3.zero;
		}
	}
}
