using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Dragon Heart/Need")]
public class Need : ScriptableObject {
    public string needName;
    public string needDescription;
    public string maxNeed;
    public string needDecayPerHour;
}
