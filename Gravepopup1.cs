using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Gravepopup1 : MonoBehaviour
{

    public string myString;
    public string myString2;
    public Image myString3;
    public Text myText;
    public Text myText2;
    public Image myImage1;
    public float fadeTime;
    public bool displayInfo;
    

    // Use this for initialization
    void Start()
    {

        myText = GameObject.FindWithTag("Header1").GetComponent<Text>();
        myText2 = GameObject.FindWithTag("Details1").GetComponent<Text>();
        myImage1 = GameObject.FindWithTag("Image1");
        

        myText.color = Color.clear;
        myText2.color = Color.clear;
        myImage1.color = Color.clear;
        //Screen.showCursor = false;
        //Screen.lockCursor = true;
    }

    // Update is called once per frame
    void Update()
    {

        FadeText();

        /*if (Input.GetKeyDown (KeyCode.Escape)) 
         
                {
                        Screen.lockCursor = false;
                         
                }
                */


    }

    void OnMouseOver()
    {
        displayInfo = true;

    }



    void OnMouseExit()

    {
        displayInfo = false;

    }


    void FadeText()

    {


        if (displayInfo)
        {

            myText.text = myString;
            myText2.text = myString2;
            myImage1.tran


            myText.color = Color.Lerp(myText.color, Color.black, fadeTime * Time.deltaTime);
            myText2.color = Color.Lerp(myText2.color, Color.black, fadeTime * Time.deltaTime);
        }

        else
        {

            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
            myText2.color = Color.Lerp(myText2.color, Color.clear, fadeTime * Time.deltaTime);
        }




    }



}