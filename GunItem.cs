using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunItem : MonoBehaviour {
    public GunType m_GunType;
    public GameObject m_AmmoPrefab;
    public int m_ClipSize;
    public float m_DamageHP;
    public float m_FiringRateSeconds;
    public float m_ReloadCoolDownSeconds;
    public float m_FireDelayOnAim;
    public float m_FireDelayAfterReload;
    public float m_AccuracyRange;
    public float m_MuzzleFlash_FlashDelay;
    public float m_MuzzleFlash_SmokeDelay;
    public string m_AmmoSpriteName;
    [Range(0.0f, 1f)]
    [Header("Weapon Aim Sway")]
    public float m_SwayValueZeroFatigue;
    [Range(0.0f, 1f)]
    public float m_SwayValueMaxFatigue;
    [Range(0.0f, 1f)]
    public float m_SwayIncreasePerSecond;
}
