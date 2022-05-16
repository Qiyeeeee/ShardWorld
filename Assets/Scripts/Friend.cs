using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Friend : MonoBehaviour
{
    public GameObject dialogImage;
    //public GameObject tipImage;
    public Text text;
    public float showTime = 4;
    private float showTimer;
    // Start is called before the first frame update
    void Start()
    {
        //tipImage.SetActive(true);
        dialogImage.SetActive(false);
        showTimer = -1;
    }

    // Update is called once per frame
    void Update()
    {
        showTimer -= Time.deltaTime;
        if (showTimer < 0)
        {
            //tipImage.SetActive(true);
            dialogImage.SetActive(false);
        }
    }

    public void ShowDialog()
    {
        //Call the PlayerControl script to determine if the several items were collected already, and then modify the text
        if (PlayerController.showflag == 10)
        {
            text.text = "Friend: \n Let's be good friends. We should be always be there for each other!";
        }
        else if (PlayerController.showflag == 11)
        {
            text.text = "Friend: \n Oh, many friend. Could you help me bring the thing over somewhere? I can't find them everywhere";
        }
        else if (PlayerController.showflag == 12)
        {
            text.text = "Friend: \n Oh, many thanks. You are my best friends.";
        }
        else if (PlayerController.showflag == 13)
        {
            text.text = "Friend: \n Wow, one really important thing just over there.But it's too difficult to catch it. Could you help me get it? I really can't do anything";
        }
        else if (PlayerController.showflag == 14)
        {
            text.text = "Friend: \n Thank you!You must be hurt. But I can't be your friend anymore. Because the way you look really scares me.Let's never see each other again ";
        }
        showTimer = showTime;
        dialogImage.SetActive(true);
        //tipImage.SetActive(false);
    }
}
