using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Charcater", menuName = "I Didn't want this/ Character", order = 1)]
public class Character : ScriptableObject {

	public string charName;
	public Color textColour;
	public Sprite[] charSprite;
    public Font[] playerFont;
    public FontStyle playerFontStyle;

	public Sprite GetSprite( int index)
	{
		if (charSprite.Length == 0)
		{
			return null;
		}

		index = Mathf.Clamp(index, 0, charSprite.Length - 1);
		return charSprite[index];
	}

    public Font GetFont( int index)
    {
        if (playerFont.Length ==0)
        {
            return null;
        }

        index = Mathf.Clamp(index, 0, playerFont.Length - 1);
        return playerFont[index];
    }
}
