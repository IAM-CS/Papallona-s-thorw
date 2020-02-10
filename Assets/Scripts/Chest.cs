using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public bool open;
    public int numcoins;

    public Chest() {}
    public Chest(bool open, int numcoins)
    {
        this.open = open;
        this.numcoins = numcoins;
    }
}
