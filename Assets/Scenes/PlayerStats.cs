using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsManager : MonoBehaviour
{
    // TextMeshPro UI Text element for displaying stats
    public TextMeshProUGUI statsText;

    // Player buttons
    public Button Player1;
    public Button Player2;
    public Button Player3;

    // Player stats
    private string player1Stats = "Player 1:\nHealth: 100\nAttack: 50\nDefense: 30";
    private string player2Stats = "Player 2:\nHealth: 120\nAttack: 40\nDefense: 40";
    private string player3Stats = "Player 3:\nHealth: 90\nAttack: 60\nDefense: 20";

    void Start()
    {
        // Set up button listeners to update stats text
        Player1.onClick.AddListener(() => DisplayStats(player1Stats));
        Player2.onClick.AddListener(() => DisplayStats(player2Stats));
        Player3.onClick.AddListener(() => DisplayStats(player3Stats));
    }

    // Function to display player stats
    void DisplayStats(string stats)
    {
        statsText.text = stats;
    }
}
