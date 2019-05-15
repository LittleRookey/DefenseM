using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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

    
    public int gold
    {
        get
        {
            if(!PlayerPrefs.HasKey("Gold"))
            {
                return 0;
            }

            return PlayerPrefs.GetInt("Gold");

        }

        set
        {
            PlayerPrefs.SetInt("Gold", value);
        }
    }

    public int goldPerClick
    {
        get
        {

            return PlayerPrefs.GetInt("GoldPerClick", 1);
        }

        set
        {
            PlayerPrefs.SetInt("GoldPerClick", value);
        }
    }

    public int strength
    {
        get
        {
            if (!PlayerPrefs.HasKey("Strength"))
            {
                return 1;
            }
            return PlayerPrefs.GetInt("Strength");
        }

        set
        {
            PlayerPrefs.SetInt("Strength", value);
        }
    }

    public int luckiness
    {
        get
        {
            if (!PlayerPrefs.HasKey("Luck"))
            {
                return 0;
            }
            return PlayerPrefs.GetInt("Luck");
        }

        set
        {
            PlayerPrefs.SetInt("Luck", value);
        }
    }

    //민첩
    public int agility
    {
        get
        {
            if(!PlayerPrefs.HasKey("Agility"))
            {
                return 1;
            }
            return PlayerPrefs.GetInt("Agility");
        }

        set
        {
            PlayerPrefs.SetInt("Agility", value);
        }
    }

    public static DateTime timeOngoing;
    public bool isTimeOngoing;

    public DateTime gameDate
    {
        get
        {
            if (!PlayerPrefs.HasKey("gameDate"))
            {
                return new DateTime(0, 1, 1, 8, 0, 0);
            }

            String timeBinaryInString = PlayerPrefs.GetString("gameDate");
            long timeBinaryInLong = Convert.ToInt64(timeBinaryInString);
            return DateTime.FromBinary(timeBinaryInLong);
        }

        set
        {
            // TODO 지우기
            long temp = timeOngoing.ToBinary();
            String dateInString = Convert.ToString(temp);
            PlayerPrefs.SetString("gameDate", value.ToString());
        }
    }

    private void Awake()
    {
        timeOngoing = new DateTime(0, 1, 1, 8, 0, 0);
        isTimeOngoing = false;
    }

    private void Start()
    {

    }
    
    private void Update()
    {
        
    }


}
