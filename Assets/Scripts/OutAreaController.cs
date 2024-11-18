using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutAreaController : MonoBehaviour
{
    void OnTriggerEnter(Collider coll){
        if(coll.gameObject.CompareTag("Player")){
            SceneManager.LoadScene(1);
        }
    }
}
