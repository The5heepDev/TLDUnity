using UnityEngine;

public class Inspect : MonoBehaviour {
    public float m_DistanceFromCamera = 0.4f;
    public Vector3 m_Scale = new Vector3(1f, 1f, 1f);
    public GameObject m_InspectModeMesh;
    public GameObject m_NormalMesh;
    public bool m_IgnoreMouse = false;
    public bool m_OverrideDepthOfFieldFocalDistance;
    public float m_DepthOfFieldFocalDistance;
    public Vector3 m_Offset;
    public Vector3 m_Angles;
    [Tooltip("Leave blank to use the general VO for item inspect")]
    public string m_OverrideInspectVO;
    public bool m_SkipInspectVO;
}
