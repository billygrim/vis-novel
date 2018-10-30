/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueProper : MonoBehaviour
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
        optionA.SetActive(false);
        optionB.SetActive(false);
    }

    // Use this for initialization
    

        nameField[0].text = " Ken";
        contentField[0].text = "i am a preverdial god ";

        nameField[0].text = "";
        contentField[0].text = "";

        nameField[1].text = "Sarah";
        contentField[1].text = " cocky as every i see.";
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}*/

    
