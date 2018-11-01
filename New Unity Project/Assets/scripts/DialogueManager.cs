using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class DialogueComponents
{
	public Character character;

	[Range(0,3)]
	public int poseIndex;

    [Range(0,2)]
    public int fontIndex;

	[TextArea]
	public string contentField;

	public bool showButton;

	public string optionA;
	public string optionB;
}

public class DialogueManager : MonoBehaviour {

	public DialogueComponents[] dialogues;

	public int index = 0;

	public Text characterName;
	public Text dialogueFields;

	public Button firstOption;
	public Button secondOption;

	public Text optionA_Text;
	public Text optionB_Text;

	
	
	public Image pose;

	


	// Use this for initialization
	void Start () {

		index = 0;

		optionA_Text.gameObject.SetActive(false);
		optionB_Text.gameObject.SetActive(false);
        pose.gameObject.SetActive(false);




    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			ShowText();
			index++;

		}
	}

	public void ShowText()
	{
		if (index < dialogues.Length)
		{
            dialogueFields.font = dialogues[index].character.GetFont(dialogues[index].fontIndex);
            dialogueFields.fontStyle = dialogues[index].character.playerFontStyle;
			characterName.text = dialogues[index].character.charName;
			dialogueFields.text = dialogues[index].contentField;
			dialogueFields.color = dialogues[index].character.textColour;
			Sprite temp = dialogues[index].character.GetSprite(dialogues[index].poseIndex);

			if (temp == null)
			{
				pose.gameObject.SetActive(false);
			}
			else
			{
				pose.gameObject.SetActive(true);
				pose.sprite = dialogues[index].character.GetSprite(dialogues[index].poseIndex); pose.sprite = dialogues[index].character.GetSprite(dialogues[index].poseIndex);
			}

			if (dialogues[index].showButton)
			{
				print("is this working");

				firstOption.gameObject.SetActive(true);
				secondOption.gameObject.SetActive(true);

				optionA_Text.gameObject.SetActive(true);
				optionB_Text.gameObject.SetActive(true);

				optionA_Text.text = dialogues[index].optionA;
				optionB_Text.text = dialogues[index].optionB;


			}

		}

	}


}
