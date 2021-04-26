using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    public GameObject center;
    public float rotateSpeed = 1;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * h * Time.deltaTime * rotateSpeed);
        
        transform.LookAt(center.transform.position);
    }
}
