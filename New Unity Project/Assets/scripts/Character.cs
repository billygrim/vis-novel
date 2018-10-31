using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Charcater", menuName = "I Didn't want this/ Character", order = 1)]
public class Character : ScriptableObject {

	public string charName;
	public Color textColour;
	public Sprite[] charSprite;

	public Sprite GetSprite( int index)
	{
		if (charSprite.Length == 0)
		{
			return null;
		}

		index = Mathf.Clamp(index, 0, charSprite.Length - 1);
		return charSprite[index];
	}
}
