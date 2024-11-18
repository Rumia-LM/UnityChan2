using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GoalManager : MonoBehaviour
{
    bool isGoal;
    public TextMeshProUGUI timeText;
    float goalTime;
    // Start is called before the first frame update
    void Start()
    {
        timeText.text="Time:00:000";
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGoal){
            goalTime+=Time.deltaTime;
        }else{
            Invoke("GoTop", 2.0f);
        }
        timeText.text="Time:"+goalTime.ToString("00.000");
    }

    void OnTriggerEnter(Collider coll){
        if(coll.gameObject.CompareTag("Player")){
            isGoal=true;
            if(PlayerPrefs.GetFloat("goalTime",9999.0f)>goalTime){
                PlayerPrefs.SetFloat("goalTime",goalTime);
            }
        }
    }

    void GoTop(){
        SceneManager.LoadScene(0);
    }
}
