using UnityEngine;

public class TurnOrderScript : MonoBehaviour
{
    [Header("Turn")]
    public int currentTurn; //the turn counter for this combat
    public bool PlayerTurn; //wether or not its the players turn
    public bool TurnAdvanceable; //wether or not the turn order is advanceabe


    private void Start()
    {
        currentTurn = 1;
        PlayerTurn = true;
        TurnAdvanceable = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space pressed");
            if (TurnAdvanceable)
            {
                AdvanceTurnOrder();

            }

        }

    }

    public void AdvanceTurnOrder()
    {
        if (PlayerTurn == true)
        {
            PlayerTurn = false;
            Debug.Log("no longer player turn");

        }
        else
        {
            currentTurn++;
            PlayerTurn = true;
            Debug.Log($"Turn {currentTurn} playerturn again");

        }

    }
}
