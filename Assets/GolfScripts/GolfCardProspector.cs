using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GolfeCardState 
{
    drawpile,
    tableau,
    target,
    discard
}

public class GolfCardProspector : Card
{
    [Header("Set Dynamically: CardProspector")]
    public GolfeCardState state = GolfeCardState.drawpile;
    public List<CardProspector> hiddenBy = new List<CardProspector>();
    public int layoutID;
    public SlotDef slotDef;

    override public void OnMouseUpAsButton() {
        Prospector.S.CardClicked(this);
        base.OnMouseUpAsButton();
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
