using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypeWriterText : MonoBehaviour
{
    private TextMeshProUGUI m_Text;
    private const float TIME_PER_CHARACTER = 0.02f;
    private const float START_ANIMATION_DELAY = 0.5f;
    private float m_TimeElapsed = 0;
    public void Start()
    {
        m_Text = GetComponent<TextMeshProUGUI>();
        Update();
    }

    public void Update()
    {
        if (m_Text == null) return;
        m_TimeElapsed += Time.deltaTime;
        m_Text.maxVisibleCharacters =
            Mathf.FloorToInt(Mathf.Max(0, (m_TimeElapsed - START_ANIMATION_DELAY) / TIME_PER_CHARACTER));
    }
}
