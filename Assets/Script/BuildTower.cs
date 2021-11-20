using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTower : MonoBehaviour
{
    public GameObject TowerBluePrint;

    public void spawnTower()
    {
        Instantiate(TowerBluePrint);
    }
}
