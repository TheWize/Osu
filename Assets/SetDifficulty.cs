using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDifficulty : MonoBehaviour
{
    public void SetTimeInManager(float setTime)
    {
        GameManager.TIME = setTime;
    }
}
