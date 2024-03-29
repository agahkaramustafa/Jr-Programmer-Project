using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductivityUnit : Unit
{
    // new variables
    private ResourcePile m_CurrentPile = null;
    public float ProductivityMultiplier = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void BuildingInRange()
    {
        // start of new code
        if (m_CurrentPile == null)
        {
            ResourcePile pile = m_Target as ResourcePile;

            if (pile != null)
            {
                m_CurrentPile = pile;
                m_CurrentPile.ProductionSpeed *=  ProductivityMultiplier;
            }
        }
        // end of new code
    }
}
