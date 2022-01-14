using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI clickText;
    [SerializeField] private Image clickButtonImage;
    [SerializeField] Sprite[] buttonSprites;

    [SerializeField] public static ui instance;

    private void Awake()
    {
        instance = this;
    }

    public void OnClickButton()
    {
        Gamemanager.instance.AddClicks(1);
        clickButtonImage.sprite = buttonSprites[Random.Range(0, buttonSprites.Length)];
    }

    public void UpdateClickText()
    {
        clickText.text = Gamemanager.instance.curClicks.ToString();
    }
}
