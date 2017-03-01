using UnityEngine;
using System.Collections;

public class SpriteAnimation : MonoBehaviour {

	[SerializeField] private SpriteRenderer spriteRenderer;
	[SerializeField] private Sprite[] sprites;
	[SerializeField] private float speed;
	private int currentSprite = 0;

	void OnEnable()
	{
		currentSprite = 0;
		if (sprites.Length > 0)
		{
			spriteRenderer.sprite = sprites[0];
			Invoke("NextSprite", speed * Time.timeScale);
		}
		else
			Debug.LogWarning("No sprites defined to this SpriteAnimation attached to " + this.gameObject.name);
	}

	void NextSprite()
	{
		currentSprite++;
		if (sprites.Length - 1 >= currentSprite)
		{
			spriteRenderer.sprite = sprites[currentSprite];
		}
		else
		{
			spriteRenderer.sprite = sprites[0];
			currentSprite = 0;
		}
		Invoke("NextSprite", speed * Time.timeScale);
	}

	void OnDisable()
	{
		CancelInvoke("NextSprite");
	}

	public float Speed
	{
		get
		{
			return speed;
		}
		set
		{
			speed = value;
		}
	}

	void Reset()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
}
