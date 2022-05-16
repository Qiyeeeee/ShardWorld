using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class YoungBoyManage : MonoBehaviour
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
        //Call the PlayerControl script to determine if the task is complete, and then modify the text
        if (PlayerController.showflag == 5)
        {
            text.text = "Yong Boy: \n Hey, what a funny face, get out there and bring my stuff to me";
        }
        if (PlayerController.showflag == 6)
        {
            text.text = "Yong Boy: \n Get out there, find a place where I can't see you again";
        }
       
        showTimer = showTime;
        dialogImage.SetActive(true);
        //tipImage.SetActive(false);
    }

    

    
    
}
