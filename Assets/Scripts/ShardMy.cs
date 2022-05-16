using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShardMy : MonoBehaviour
{
    // Start is called before the first frame update
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
        if (playerController.showflag == 15)
        {
            text.text = "Myself: \n It's really hurt.I don't want live in this word anymore.";
        }
        else if (playerController.showflag == 16)
        {
            text.text = "Myself: \n Why I still here? There must be something I need found";
        }
        else if (playerController.showflag == 17)
        {
            text.text = "Myself: \n I have got it, but I don't want to disappear immediately.";
        }
        else if (playerController.showflag == 18)
        {
            text.text = "Myself: \n I still have the dream to experience the really beatuful every scenes in the world. I still want to be alive";
        }
        else if (playerController.showflag == 19)
        {
            text.text = "Myself: \n Maybe I just tired. I need to go back to my home and have a rest. ";
        }
        showTimer = showTime;
        dialogImage.SetActive(true);
        //tipImage.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ShowDialog();
    }
}
