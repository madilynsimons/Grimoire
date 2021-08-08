using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class BoardComponent : MonoBehaviour
{
    private readonly CardSpotComponent[][] m_cardSpotComponents;
    
    private readonly string[] m_rowNames;
    private readonly string[] m_columnNames;

    public BoardComponent()
    {
        m_columnNames = new []{
            "Column1",
            "Column2",
            "Column3",
            "Column4",
            "Column5",
            "Column6",
            "Column7",
            "Column8",
            "Column9"
        };
        
        m_rowNames = new[]{
            "Row1",
            "Row2",
            "Row3",
            "Row4",
            "Row5",
        };

        m_cardSpotComponents = new CardSpotComponent[m_columnNames.Length][];
        for (int col = 0; col < m_columnNames.Length; col++)
        {
            m_cardSpotComponents[col] = new CardSpotComponent[m_rowNames.Length];
            for (int row = 0; row < m_rowNames.Length; row++)
            {
                m_cardSpotComponents[col][row] = null;
            }
        }
    }

    public CardSpotComponent GeneralP1Default => GetCardSpotComponent(0, 2);

    public CardSpotComponent GeneralP2Default => GetCardSpotComponent(8, 2);

    private CardSpotComponent GetCardSpotComponent(int col, int row)
    {
        if (m_cardSpotComponents[col][row] == null)
        {
            string columnName = m_columnNames[col];
            string rowName = m_rowNames[row];
            
            var cardSpotGameObject = GameObject.Find($"{columnName}/{rowName}");
            m_cardSpotComponents[col][row] = cardSpotGameObject.GetComponent<CardSpotComponent>();
        }

        return m_cardSpotComponents[col][row];
    }
}
