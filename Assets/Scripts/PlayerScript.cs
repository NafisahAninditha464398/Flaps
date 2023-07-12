using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float speedY = 3;
    Rigidbody2D rigidb;

    // Animator animator;

    void Start()
    {
        rigidb = GetComponent<Rigidbody2D>();
        // animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)
        || Input.GetMouseButtonDown(0)) {
            rigidb.velocity = new Vector2(0, speedY);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
