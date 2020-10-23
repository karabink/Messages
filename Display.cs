using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    // Start is called before the first frame update

    public Text doorsText;
    public Text livesText;

    public GameObject messageText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        doorsText.text = "Number of open / closed doors: " + Storage.Doors.ToString();
        livesText.text = "Lives:" + Storage.Lives.ToString();
        if (Storage.GameOver)
        {
            (messageText).SetActive(true);
        }
    }
}
