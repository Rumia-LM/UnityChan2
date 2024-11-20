using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*Input.GetAxis("Horizontal")*100f*Time.deltaTime);
        //cc.Move(transform.forward*Input.GetAxis("Vertical")*5.0f*Time.deltaTime);
        cc.SimpleMove(transform.forward*Input.GetAxis("Vertical")*700.0f*Time.deltaTime);
    }
}
