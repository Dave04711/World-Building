using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureSetup : MonoBehaviour
{
    [SerializeField] Camera m_Camera;
    [SerializeField] Material m_Material;

    private void Start()
    {
        m_Camera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        m_Material.mainTexture = m_Camera.targetTexture;
    }
}