using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    private static DataController instance;

    public static DataController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DataController>();
                if (instance == null)
                {
                    GameObject container = new GameObject("DataController");
                    instance = container.AddComponent<DataController>();
                }
            }
            return instance;
        }
    }

    public int Gold
    {
        get
        {

        }
    }

}
