using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour {

	public float moveSpeed = 0.1f;  

	public KeyCode rightKey = KeyCode.RightArrow;
	public KeyCode leftKey = KeyCode.LeftArrow;
    public KeyCode upkey = KeyCode.UpArrow;
	public float bottomOfScreen = -5f;

	public string sceneToSwitchToOnDeath = "GameOverScene";

    public Vector3 jump;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    Rigidbody rb;

    // Use this for initialization
    void Start () {
	}

   // rb = GetComponent<Rigidbody2D>();
     //        jump = new Vector3(0.0f, 2.0f, 0.0f);


    // Update is called once per frame
    void Update () {
        if (Input.GetKey(upkey) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        if (Input.GetKey(rightKey)) {
			transform.Translate(moveSpeed, 0, 0);
		}
		if (Input.GetKey(leftKey)) {
			transform.Translate(-moveSpeed, 0, 0);
		}

		if (transform.position.y < bottomOfScreen) {
			SceneManager.LoadScene(sceneToSwitchToOnDeath);
		}
	}
}
