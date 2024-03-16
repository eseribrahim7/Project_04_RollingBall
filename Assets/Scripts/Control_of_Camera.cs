using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_of_Camera : MonoBehaviour
{
    public GameObject Sphere;
    public Vector3 distance_between_camera_and_sphere;

    // Start is called before the first frame update
    void Start()
    {
        distance_between_camera_and_sphere = transform.position - Sphere.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Sphere.transform.position + distance_between_camera_and_sphere;
    }
}
