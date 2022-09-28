using UnityEngine;

public class Drawbridge : MonoBehaviour
{
    public float[] m_Targets = { 90.0f, 0.0f };
    private int m_Index = 0;
    private HingeJoint m_Joint;

    private Renderer m_renderer;

    private void Awake()
    {
        m_Joint = GetComponent<HingeJoint>();
        m_renderer = GetComponent<Renderer>();
    }

    private void Draw()
    {
        JointSpring spring = m_Joint.spring;
        m_Index = ++m_Index % m_Targets.Length;
        spring.targetPosition = m_Targets[m_Index];
        m_Joint.spring = spring;
    }

    private void OnMouseEnter()
    {
        m_renderer.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        m_renderer.material.color = Color.white;
    }

    private void OnMouseUp()
    {
        Draw();
    }

}