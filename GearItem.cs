using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearItem : MonoBehaviour {
    public LocalizedString m_LocalizedDisplayName;
    public LocalizedString m_LocalizedDescription;

    public GearTypeEnum m_Type;

    public float m_WeightKG;
    public float m_MaxHP;
    public float m_DailyHPDecay;
}
