using UnityEngine;
// https://medium.com/@kleberandrade/trabalhando-com-joints-na-unity-9eaacc7632c6
public class ChangeColor : MonoBehaviour
{
    public Color m_MinColor = Color.white;
    public Color m_MaxColor = Color.white;
    private Renderer m_Renderer;

    private void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        Color color = Color.Lerp(m_MinColor, m_MaxColor, Random.Range(0.0f, 1.0f));
        m_Renderer.material.SetColor("_Color", color);
    }
}
