using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    [SerializeField]
    private Text goldText, dateText;

    

    // Start is called before the first frame update
    void Start()
    {
        goldText.text = "Gold: " + DataController.Instance.gold.ToString();    
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = DataController.Instance.gold.ToString();
        dateText.text = DataController.timeOngoing.ToString();
    }
}
