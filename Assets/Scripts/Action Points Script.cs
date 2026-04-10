using UnityEngine;
using TMPro;

public class ActionPointsScript : MonoBehaviour
{
    [Header("energy related")]
    public int currentEnergy;
    public int maxEnergy;
    public int expectedEnergy;
    public int energyRemovalService; // Temporary int for testing purposes

    [Header("game objects")]
    public TMP_Text TMP_Text;
    void Start()
    {
        addEnergy(expectedEnergy);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E Pressed");
            addEnergy(expectedEnergy);

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Q Pressed");
            removeEnergy(energyRemovalService);
        }
    }

    public void addEnergy(int energy)
    {
        Debug.Log("Adding Energy...");
        if(energy > maxEnergy - currentEnergy)
        {
            Debug.Log("Energy Set To Max");
            currentEnergy = maxEnergy;
        }
        else
        {
            Debug.Log("Added " +  energy + "Energy");
            currentEnergy = currentEnergy + energy;
        }
        updateText();

    }

    public void removeEnergy(int energy)
    {
        Debug.Log("Removing Energy...");
        if (energy < currentEnergy)
        {
            Debug.Log("Removed " + energy + " Energy");
            currentEnergy = currentEnergy - energy;
        }
        else
        {
            Debug.Log("Energy Set To 0");
            currentEnergy = 0;
        }
        updateText();

    }

    void updateText()
    {
        TMP_Text.text = currentEnergy + "/" + maxEnergy;
    }
}
