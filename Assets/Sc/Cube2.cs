using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            SceneManager.LoadScene("Scene1");
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            Debug.Log("num:"+Cube1.instance.GetNum());
        }
    }
}
