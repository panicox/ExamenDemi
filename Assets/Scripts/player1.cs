using UnityEngine;
using System.Collections;


public class player1 : MonoBehaviour {
	public float velocidad = 5f;
	public float power = 1f;
	private Rigidbody2D rb;

	void start (){

		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("right")) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
		}

		if (Input.GetKeyUp ("right")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}

		if (Input.GetKey ("up")) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
		}

		if (Input.GetKeyUp ("up")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}

		if (Input.GetKey ("left")) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
		}

		if (Input.GetKeyUp ("left")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}

		if (Input.GetKey ("down")) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
		}
		if (Input.GetKeyUp ("down")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}
	}
}