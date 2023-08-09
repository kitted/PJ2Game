using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public float moveSpeed;
    float xInput;
    float yInput;
    Rigidbody rb;
    int coinsCollected = 0;
    public GameObject winText;
    public GameObject resetGame;
    public GameObject exitGame;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        if(transform.position.y < -5f)
        {
            SceneManager.LoadScene(0);
        }
    }
    private void FixedUpdate()
    {
        rb.AddForce(xInput * moveSpeed, 0, yInput * moveSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            coinsCollected++;
            
            other.gameObject.SetActive(false);
            scoreText.GetComponent<Text>().text = "Score: " + coinsCollected.ToString() + "/7";
        }

        if(coinsCollected >= 7)
        {
            winText.SetActive(true);
            resetGame.SetActive(true);
            //exitGame.SetActive(true);

        }
    }
}
