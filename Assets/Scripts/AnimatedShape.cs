using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityFigmaBridge.Runtime.UI;

public class AnimatedShape : MonoBehaviour
{
    private FigmaImage m_FigmaImage;
    private Vector2 m_StartSizeDelta;
    private float m_StartRotation;
    private RectTransform m_RectTransform;
    private float m_TimeElapsed = 0;
    private Gradient m_Gradient;
    private bool m_AnimateGradient;
    private Color[] m_InitialGradientColours;
    
    void Start()
    {
        m_FigmaImage = GetComponent<FigmaImage>();
        if (m_FigmaImage == null) return;
        m_RectTransform=transform as RectTransform;
        m_StartSizeDelta = m_RectTransform.sizeDelta;
        m_StartRotation = m_RectTransform.transform.rotation.eulerAngles.z;
        m_AnimateGradient = m_FigmaImage.Fill switch
        {
            FigmaImage.FillStyle.LinearGradient => true,
            FigmaImage.FillStyle.RadialGradient => true,
            _ => false
        };
        if (m_AnimateGradient)
        {
            m_Gradient = m_FigmaImage.FillGradient;
            m_InitialGradientColours=new Color[m_Gradient.colorKeys.Length];
            for (var i = 0; i < m_Gradient.colorKeys.Length; i++)
            {
                m_InitialGradientColours[i] = m_Gradient.colorKeys[i].color;
            }
        }
    }

    
    void Update()
    {
        if (m_FigmaImage == null) return;
        m_TimeElapsed += Time.deltaTime;
        var sizeDeltaModification = new Vector2(Mathf.Cos(m_TimeElapsed), Mathf.Sin(m_TimeElapsed*2.0f));
        m_RectTransform.sizeDelta = m_StartSizeDelta * (Vector2.one+sizeDeltaModification * 0.2f);
        if (m_AnimateGradient)
        {
            var keys = m_Gradient.colorKeys;
            // Shift hues
            for (var i = 0; i < m_InitialGradientColours.Length; i++)
            {
                Color.RGBToHSV(m_InitialGradientColours[i],out var h, out var s, out var v);
                h += m_TimeElapsed*0.1f;
                h %= 1f;
                keys[i].color = Color.HSVToRGB(h, s, v);
            }
            m_Gradient.SetKeys(keys,m_Gradient.alphaKeys);
            m_FigmaImage.FillGradient = m_Gradient;
        }
    }
}
