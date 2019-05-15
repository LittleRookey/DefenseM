using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timeStart());
    }


    private IEnumerator timeStart()
    {
        DataController.Instance.isTimeOngoing = true;
        while (DataController.Instance.isTimeOngoing)
        {
            //DataController.timeOngoing.AddSeconds(1f);
            yield return new WaitForSeconds(1f);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
