using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Security.Authentication.ExtendedProtection;

public class Time_controller : MonoBehaviour
{


    [SerializeField] int min, seg;
    [SerializeField] Text Totaltime;
    // Start is called before the first frame update


    public string Scene;
    private float Timer;
    private bool On;

    private void Awake()
    {
        Timer = (min * 60) + seg;

        On = true;

    }


    // Update is called once per frame
    void Update()
    {
        if (On)
        {
            Timer -= Time.deltaTime;
            if (Timer < 0)
            {
                SceneManager.LoadScene(Scene);

            }
            int tempMin = Mathf.FloorToInt(Timer / 60);
            int tempSeg = Mathf.FloorToInt(Timer % 60);
            Totaltime.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);


        }

    }
}
