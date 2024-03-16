using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control_of_Ball : MonoBehaviour
{
    public Rigidbody physics;
    public int speed;
    public int points;
    public int objectNumber;

    public Text pointsText;
    public Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        physics = GetComponent<Rigidbody>();
        //transform.Translate(0, 0, -10);
        speed = 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(0, 0, 0.01f);
        //transform.Rotate(0, -3, -0.1f);

        //if(Input.GetKeyDown(KeyCode.Escape))
        //{
        //    Debug.Log("Pressed ESC!");
        //}

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //float jump = Input.GetAxisRaw("Jump");
        //physics.AddForce(horizontal*speed, 0, vertical*speed);

        Vector3 vector = new Vector3(horizontal, 0, vertical);

        physics.AddForce(vector * speed);

        //Debug.Log("horizontal = " + horizontal);
        //Debug.Log("vertical = " + vertical);
        //Debug.Log(transform.position);


    }

    // void OnTriggerExit(Collider other)
    //{
    //    other.gameObject.SetActive(false);
    //}
    // void OnTriggerStay(Collider other)
    //{
    //    Debug.Log("There is a collision now!");
    //}

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("There is collision!");
        other.gameObject.SetActive(false);
        points++;
        //Debug.Log("Points = " + points);
        pointsText.text = "Points = " + points;

        if (points == objectNumber)
        {
            //Debug.Log("Game Over!");
            gameOverText.gameObject.SetActive(true);
        }
    }
}
