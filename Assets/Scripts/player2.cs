using UnityEngine;
using System.Collections;


	public class player2 : MonoBehaviour {
	public float velocidad = 5f;
	public float power = 1f;
	private Rigidbody2D rb;

	void start (){
		
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("d")) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
		}

		if (Input.GetKeyUp ("d")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}

		if (Input.GetKey ("w")) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
		}

		if (Input.GetKeyUp ("w")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}

		if (Input.GetKey ("a")) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
		}
		if (Input.GetKeyUp ("a")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}

		if (Input.GetKey ("s")) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
		}
		if (Input.GetKeyUp ("s")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}
	}
}