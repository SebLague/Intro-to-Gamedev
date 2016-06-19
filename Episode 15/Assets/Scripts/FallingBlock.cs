using UnityEngine;
using System.Collections;

public class FallingBlock : MonoBehaviour {

	public Vector2 speedMinMax;
	float speed;

	void Start() {
		speed = Mathf.Lerp (speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent ());
	}

	void Update () {
		transform.Translate (Vector3.down * speed * Time.deltaTime, Space.Self);
	}
}
