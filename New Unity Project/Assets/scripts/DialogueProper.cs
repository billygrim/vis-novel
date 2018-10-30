using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueProperSceneOne : MonoBehaviour
{
    /// <summary>
    /// used as a refernece to the name and dialogur fields
    /// </summary>
    
    public Text[] contentField;
    public Text[] nameField;

    /// used to keep track of the buttons need to move text along ///
   
    public Button[] continueButtons = new Button[3];

    //// used to keep trak of the line count in order to make sure that the dialogue scrpit males sense and isnt jumping and looping///

    public int scriptController = 0;
    public int optionA_ScriptCon = 0;
    public int optionB_ScriptCon = 0;

    //// used as proxy buttons to alllow for the different choices////
   

    public GameObject optionA;
    public GameObject optionB;
    public Text choiceA_Field;
    public Text choiceB_Field;

    public GameObject imageOne;
    public GameObject imageTwo;
    public GameObject imageThree;
  

    /// <summary>
    /// for buttons 
    /// 
    /// index 0 = for main stort
    /// index 2 = for main story after option a
    /// index 3 = for main story after option b
    ///</summary>

    /// <summary>
    /// for name and dialouge text fileds
    /// 
    /// index 0 = player character
    /// index 1 = sarah
    /// index 2 = naimi
    /// index 3 = chiaki
    /// index 4 =- any cahacter who identity must be hidden at any point in time
    /// </summary>



    private void Awake()
    {
        continueButtons[0].enabled = true;
        continueButtons[1].enabled = false;
        continueButtons[2].enabled = false;

        imageOne.SetActive(true);
        imageTwo.SetActive(false);
        imageThree.SetActive(false);

        optionA.SetActive(false);
        optionB.SetActive(false);
    }

   

    public void InitialScript()
    {
        scriptController = scriptController +1;
        print(scriptController);

        if (scriptController ==1)
        {
            nameField[0].text = " Ken";
            contentField[0].text = "i am a preverdial god ";

        }

        if (scriptController == 2)
        {

            nameField[0].text = "";
            contentField[0].text = "";

            nameField[1].text = "Sarah";
            contentField[1].text = " cocky as every i see.";
        }

        if (scriptController == 3)
        {
            nameField[1].text = "";
            contentField[1].text = " ";

            nameField[0].text = "Ken";
            contentField[0].text = "I'm not cocky, I'm just honest";
        }

        if (scriptController == 4)
        {
            nameField[0].text = "";
            contentField[0].text = "";

            nameField[1].text = "Sarah";
            contentField[1].text = " Hahaha, very funny. On a side note. Do you wanna come over to my place this weekend? dont worry my folks aren't home";

            optionA.SetActive(true);
            choiceA_Field.text = "Sure, I'm Always down to vist";

            optionB.SetActive(true);
            choiceB_Field.text = "Sorry, not possible..";
        }
    }

    public void FirstScrit()
    {
        //   CanOne.enabled = false;
        //  canTwo.enabled = true;

        imageOne.SetActive(false);
        imageTwo.SetActive(true);
     


        optionA.SetActive(false);
        optionB.SetActive(false);
        
        optionA_ScriptCon = optionA_ScriptCon + 1;
        print(optionA_ScriptCon);
        

        if (optionA_ScriptCon == 1)
        {
            nameField[1].text = "Sarah";
            contentField[1].text = "Really, that's so cool. i really thought you'd turn me down ";
        }

        if (optionA_ScriptCon == 2)
        {
            nameField[1].text = "";
            contentField[1].text = "";

            nameField[0].text = "Ken";
            contentField[0].text = " And why would i turn you down";
        }
    }

    public void SecondScript()
    {
        imageOne.SetActive(false);
        imageThree.SetActive(true);


        // CanOne.enabled = false;
        // canThree.enabled = true;

        optionA.SetActive(false);
        optionB.SetActive(false);

        optionB_ScriptCon = optionB_ScriptCon + 1;
        print(optionB_ScriptCon);

        if (optionB_ScriptCon == 1)
        {
            nameField[1].text = "Sarah?";
            contentField[1].text = " Well im not really surprised, maybe some other time then?";
        }

        if (optionB_ScriptCon == 2)
        {
            nameField[1].text = "";
            contentField[1].text = "";

            nameField[0].text = "Ken";
            contentField[0].text = "Yeah, mayeb some other time";
        }
    }
}

    
