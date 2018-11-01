using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Background", menuName = "I Didn't want this/ Background", order = 2)]
public class Background : ScriptableObject
{
    public Sprite backgroundImage;
    public Color imageAlpha;
}
