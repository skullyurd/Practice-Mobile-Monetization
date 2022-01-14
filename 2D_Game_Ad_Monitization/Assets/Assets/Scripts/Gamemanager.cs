using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] public int curClicks;

    [SerializeField] public static Gamemanager instance;


    private void Awake()
    {
        instance = this;
    }

    public void AddClicks(int amount)
    {
        curClicks += amount;
        ui.instance.UpdateClickText();
    }
}
