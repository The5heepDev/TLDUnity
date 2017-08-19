using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour {

    [Header("Decay")]
    public float m_DailyHPDecayInside;
    public float m_DailyHPDecayOutside;

    [Header("Calories")]
    public float m_CaloriesRemaining;
    public float m_CaloriesTotal;

    [Header("Eating")]
    public float m_TimeToEatSeconds;
    public float m_TimeToOpenAndEatSeconds;
    public float m_ChanceFoodPoisoning;
    public float m_ChanceFoodPoisoningLowCondition;

    [Tooltip("The chance of parasites increases based on how many units you've eaten")]
    public float[] m_ParasiteRiskPercentIncrease;

    [Header("Audio")]
    public string m_EatingAudio;
    public string m_OpenAndEatingAudio;

    [Header("Properties")]
    public bool m_IsDrink;
    public bool m_IsMeat;
    public bool m_IsFish;
    public bool m_IsRawMeat;
    public bool m_IsNatural;

    [Header("Cooking")]
    public bool m_StayHeatedUntilInteraction;
    public bool m_HeatedWhenCooked;

    [Range(0.0f, 100f)]
    public float m_PercentHeatLossPerMinuteIndoors;

    [Range(0.0f, 100f)]
    public float m_PercentHeatLossPerMinuteOutdoors;

    [Header("Misc")]
    public float m_ReduceThirst;
    public bool m_Packaged;

}
