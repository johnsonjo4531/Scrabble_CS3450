using System;

public class Player
{
    // Player class member variables
    private string name;
    private LetterRack letterRack;
    private int playerID;
    private int skipCount;
    private int score;
    private bool hasTurnPriority;

    public Player(int userID, string username)
    {
        playerID = userID;
        name = username;
    }

    // BEGIN GETTER FUCTIONS
    public int GetScore()
    {
        return score;
    }

    public LetterRack GetLetterRack()
    {
        return letterRack;
    }

    public int GetSkipCount()
    {
        return skipCount;
    }

    public bool GetHasTurnPriority()
    {
        return hasTurnPriority;
    }

    public string GetName()
    {
        return name;
    }

    public int GetPlayerID()
    {
        return playerID;
    }
    // END GETTER FUNCTIONS

    public void AddToScore(int points)
    {
        score += points;
    }

    public void GiveTurnPriority()
    {
        hasTurnPriority = true;
    }

    public void RemoveTurnPriority()
    {
        hasTurnPriority = false;
    }

    public void IncrementSkipCount()
    {
        skipCount++;
    }

    public void DecrementSkipCount()
    {
        skipCount--;
    }
}

