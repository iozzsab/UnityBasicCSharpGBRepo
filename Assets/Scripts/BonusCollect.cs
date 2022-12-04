using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UIElements;

public class BonusCollect : MonoBehaviour
{
    [SerializeField] private int bonusCount;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RecountBonus(int bonusPoint)
    {

        if (bonusPoint > 0)

            bonusCount += bonusPoint;
        Debug.Log("Очков ровно " + bonusCount);

        if (bonusCount >= 50)
            Debug.Log("Вы Выиграли");
    }
}


