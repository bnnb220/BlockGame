using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    private new Camera camera;
    
    private Transform currFullBlockTr;
    private bool isBlockTouched;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        MouseEvent();
        TouchBlock();
    }

    void MouseEvent()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(!isBlockTouched)
            {
                ray = camera.ScreenPointToRay(Input.mousePosition);
                if(Physics.Raycast(ray, out hit, 1000.0f, 1<<7))
                {
                    currFullBlockTr = hit.collider.gameObject.GetComponentInParent<Transform>();
                    isBlockTouched = true;
                }
            }
            
        }
        else if(Input.GetMouseButtonUp(0))
        {
            currFullBlockTr = null;
            isBlockTouched = false;
        }
    }

    void TouchBlock()
    {
        if(currFullBlockTr)
        {
            //currFullBlockTr.position = camera.transform.position + camera.transform.forward * 3.0f;
            //currFullBlockTr.position = Input.mousePosition + camera.transform.forward * 3.0f;
            Debug.Log(Input.mousePosition);
        }
    }
}

