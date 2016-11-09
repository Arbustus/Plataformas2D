using UnityEngine;
using System.Collections;

public class Moneda : MonoBehaviour {

	Rigidbody2D rb;

	void Start (){
		Destroy (gameObject, 3);
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (new Vector2 (Random.Range (-200,200), Random.Range (50,200)));
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Destroy(gameObject);
		}
	}
}
