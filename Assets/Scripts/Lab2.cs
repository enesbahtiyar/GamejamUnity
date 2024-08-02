using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lab2 : MonoBehaviour
{
    //if - else - #if - ternary
    //switch
    //input.getkey
    //scenemanager
    //playerprefs - diğer save metodları - hileyi nasıl engelleriz

    //[SerializeField] string weather = "";
    //string activity = "";
    [SerializeField]float rotatespeed;

    private void Start()
    {
    }

    private void Update()
    {
        /*
#if UNITY_EDITOR
        //if - else
        if(weather == "rainy")
        {
            activity = "cinema";
        }
        else
        {
            activity = "gaming";
        }

        //ternary
        activity = weather == "rainy" ? "cinema" : "gaming";

        //switch
        switch(weather)
        {
            case "rainy":
                activity = "cinema";
                break;
            case "sunny":
                activity = "picnic";
                break;
            default:
                activity = "gaming";
                break;
        }
#endif

        Debug.Log(activity);
        */


        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, rotatespeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, -rotatespeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(rotatespeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(-rotatespeed * Time.deltaTime, 0, 0);
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
