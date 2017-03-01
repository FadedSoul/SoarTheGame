using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    [SerializeField]
    private PlayerLifes playerLifes; // Done

    public void AddLife()
    {
        playerLifes.AddLife();
    }
}
