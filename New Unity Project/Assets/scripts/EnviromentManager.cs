using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Enviroments
{
    public Background background;
}

public class EnviromentManager : MonoBehaviour {

    public Enviroments[] enviroments;

    public int interger;

    public Image picture;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DisplayEnvironment()
    {
        picture.sprite = enviroments[interger].background.backgroundImage;
        picture.color = enviroments[interger].background.imageAlpha;
    }
}
