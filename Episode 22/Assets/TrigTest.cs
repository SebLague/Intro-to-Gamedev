using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigTest : MonoBehaviour {

	public float angleInDegrees;

	void Update () {

		Vector3 direction = new Vector3 (Mathf.Sin (angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos (angleInDegrees * Mathf.Deg2Rad));
		Debug.DrawRay (transform.position, direction * 3, Color.green);

		Vector3 inputDir = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")).normalized;
		transform.Translate (inputDir * Time.deltaTime * 5, Space.World);

		float inputAngle =Mathf.Atan2 (inputDir.x, inputDir.z) * Mathf.Rad2Deg;
		transform.eulerAngles = Vector3.up * inputAngle;
	}
}
