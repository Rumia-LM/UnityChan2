using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube1 : MonoBehaviour
{
    public static Cube1 instance;
    int num=0;
    void Awake(){
        if(instance==null){
            instance=this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            num++;
            Debug.Log(num);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            SceneManager.LoadScene("Scene2");
        }
    }

    public int GetNum(){
        return this.num;
    }
}
