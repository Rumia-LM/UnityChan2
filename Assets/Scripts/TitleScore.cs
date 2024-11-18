using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TitleScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text ="BestTime:"+PlayerPrefs.GetFloat("goalTime",9999.99f).ToString("00.000");
    }

}
