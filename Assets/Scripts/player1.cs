using UnityEngine;
using System.Collections;


public class player1 : MonoBehaviour {
	public float velocidad = 5f;
	public float power = 1f;
	private Rigidbody2D rb;

	void Start (){

		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.x);
			transform.localScale = new Vector3 (1, 1, 1);
		}

		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			rb.velocity = new Vector2 (0, rb.velocity.x);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.x);
			transform.localScale = new Vector3 (-1, 1, 1);
		}
		if (Input.GetKeyUp (KeyCode.DownArrow)) {
			rb.velocity = new Vector2 (0, rb.velocity.x);
		}
	}
}