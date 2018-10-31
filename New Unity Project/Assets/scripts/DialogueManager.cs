using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class DialogueComponents
{
	public Character character;
	[Range(0,3)]
	public int poseIndex;

	[TextArea]
	public string contentField;
}

public class DialogueManager : MonoBehaviour {

	public DialogueComponents[] dialogues;

	public int index = 0;

	public Text characterName;
	public Text dialogueFields;
	public Image pose;
	


	// Use this for initialization
	void Start () {

		index = 0;
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
			characterName.text = dialogues[index].character.charName;
			dialogueFields.text = dialogues[index].contentField;
			dialogueFields.color = dialogues[index].character.textColour;
			Sprite temp = dialogues[index].character.GetSprite(dialogues[index].poseIndex);

			if (temp==null)
			{
				pose.gameObject.SetActive(false);
			}
			else
			{
				pose.gameObject.SetActive(true);
				pose.sprite = dialogues[index].character.GetSprite(dialogues[index].poseIndex); pose.sprite = dialogues[index].character.GetSprite(dialogues[index].poseIndex);
			}


			



		}
		



	}


}
