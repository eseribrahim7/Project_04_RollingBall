using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_of_Object : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3(15, 30, 45);
        transform.Rotate(vector * speed);
    }
}
