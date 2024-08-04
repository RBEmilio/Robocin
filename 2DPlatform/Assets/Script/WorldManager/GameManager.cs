using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int TotalPoints { get { return totalPoints; } }
    private int totalPoints;

    public int SpecialPoints {  get { return specialPoints; } }
    private int specialPoints;


    public void Points(int more)
    {
        totalPoints += more;
    }

    public void TotalSpecial(int more)
    {
        specialPoints += more;
    }
}
