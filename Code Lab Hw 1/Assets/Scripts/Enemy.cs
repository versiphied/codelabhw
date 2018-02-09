using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    public float moveSpeed = 0.1f;

    public KeyCode D = KeyCode.D;
    public KeyCode A = KeyCode.A;

    public float bottomOfScreen = -5f;

    public string sceneToSwitchToOnDeath = "GameOverScene";

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(D))
        {
            transform.Translate(moveSpeed, 0, 0);
        }
        if (Input.GetKey(A))
        {
            transform.Translate(-moveSpeed, 0, 0);
        }

        if (transform.position.y < bottomOfScreen)
        {
            SceneManager.LoadScene(sceneToSwitchToOnDeath);
        }
    }
}
