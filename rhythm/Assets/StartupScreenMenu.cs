using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupScreenMenu : MonoBehaviour
{
    public GameObject startupMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        startupMenuUI.SetActive(true);
        Time.timeScale = 0f;
        //GameIsPaused = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            startupMenuUI.SetActive(false);
            Time.timeScale = 1f;
            //GameIsPaused = false;
        }
    }
}
