/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Dialogue : MonoBehaviour
{
    public Text ContentTextForMe;
    public Text contentTextForNaomi;
    public Text contentTextForSarah;
    public Text contentTextForChiaki;
    public Text contentTexForUnkownCharacter;
    public Text nameTextForMe;
    public Text nameTextForNaomi;
    public Text nameTextForSarah;
    public Text nameTextForChiaki;
    public Text nameTextForUnkownCharacter;

    public Image backgroud;

    public int lineContoller = 0;
    public int firstOptionController = 0;
    public int secondOptionController = 0;

    public GameObject optionA;
    public Text choiceA_Field;
    public Text choiceB_Field;
    public GameObject optionB;

    public string newScene;

    public Button continueButton;
    public Button continueButtonA;
    public Button continueButtonB;

   // public Canvas canA;
   // public Canvas canB;

    public Image image;

    private void Awake()
    {

        optionA.SetActive(false);
        optionB.SetActive(false);
        continueButtonA.enabled = false;
        continueButtonB.enabled = false;
        continueButton.enabled = true;

        image.enabled = true;

        //canA.enabled = true;
       // canB.enabled = false;
    }

    public void Script()
    {

        
        lineContoller = lineContoller + 1;
        print(lineContoller);

        // unkwown Character dialogue//

        if (lineContoller == 1)
        {
            nameTextForUnkownCharacter.text = "";
            contentTexForUnkownCharacter.text = " where do you think you going";
        }

        if (lineContoller == 2)
        {
            nameTextForUnkownCharacter.text = "";
            contentTexForUnkownCharacter.text = "you belong to me, and ONLY ME !!!";
                
        }

        if (lineContoller == 3)
        {
            nameTextForUnkownCharacter.text = "";
            contentTexForUnkownCharacter.text = "AHAHAHAHAHAHAHAHAHA";
        }

        if ( lineContoller ==4)
        {
            nameTextForMe.text = "me";
            contentTexForUnkownCharacter.text = "";
            ContentTextForMe.text = " how did i get here, oh it was her. her. her .HER HER HER, It's all her fault. HERS HERS HERS HERS.....";

        }

        if (lineContoller == 5)
        {
           nameTextForMe.text = "me";
            contentTexForUnkownCharacter.text = ""; 
           ContentTextForMe.text= "I SHOULD HAVE NEVER LISTENED TO HER";

        }


       
        if (lineContoller==6)
        {
            nameTextForMe.text = "";
            contentTexForUnkownCharacter.text = "";
            ContentTextForMe.text = "";
            optionA.SetActive(true);
            optionB.SetActive(true);

            image.enabled = false;

        }

        if (lineContoller == 7)
        {
            choiceA_Field.text = " i dont want this";
            choiceB_Field.text = " i want my life back";
        }
    }
    
     public void firstOption()
     {
        continueButton.enabled = false;
        continueButtonA.enabled = true;

        print(firstOptionController);
        firstOptionController = firstOptionController + 1;

        if (firstOptionController ==1)
        {
            nameTextForChiaki.text = "Chiaki";
            contentTextForChiaki.text = " hey sleepy head, seems like you managed to wake up today";
        }

        if (firstOptionController ==2)
        {
            nameTextForChiaki.text = "";
            contentTextForChiaki.text = "";
            nameTextForMe.text = "Ken";
            ContentTextForMe.text = " you know, i should be the one saying that. you the one whose always late to school";
        }
     }

   public void SecondOption()
    {
      


        print(secondOptionController);
        secondOptionController = secondOptionController = 1;

        if (secondOptionController ==1)
        {
            nameTextForSarah.text = " Sarah";
            contentTextForSarah.text = "hey hot stuff. you still mine, nothing you do will change that...";
        }
    }

}*/
    
