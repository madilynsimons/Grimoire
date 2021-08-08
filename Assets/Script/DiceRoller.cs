using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class DiceRoller : MonoBehaviour
{
    private readonly System.Random m_random;
    private TextComponent m_diceTextComponent;


    public DiceRoller()
    {
        m_random = new System.Random();
    }

    // Start is called before the first frame update
    void Start()
    {
        m_diceTextComponent = GameObject.FindGameObjectWithTag("Dice").GetComponent<TextComponent>();
    }

    private void OnMouseUp()
    {
        int result = m_random.Next(0, 12) + 1;
        m_diceTextComponent.TextMesh.text = $"{result}";
    }
}
