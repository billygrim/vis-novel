using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SceneFader : MonoBehaviour
{

	public CanvasGroup canvasGroup;

	private void Start()
	{
		StartCoroutine(FadeOut());
	}

	IEnumerator FadeOut()
	{
		for (float t = 0; t < 1; t += Time.deltaTime)
		{
			canvasGroup.alpha = Mathf.Lerp(1, 0, t);
			yield return new WaitForEndOfFrame();
		}
	}
	
	IEnumerator FadeIn()
	{
		for (float t = 0; t < 1; t += Time.deltaTime)
		{
			canvasGroup.alpha = Mathf.Lerp(0, 1, t);
			yield return new WaitForEndOfFrame();
		}
	}

	public void In()
	{
		StartCoroutine(FadeIn());
	}
	
	public void Out()
	{
		StartCoroutine(FadeOut());
	}
	
}
