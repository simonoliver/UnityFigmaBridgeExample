using TMPro;
using UnityEngine;
using UnityFigmaBridge;

public class CodeScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI CounterText;

    private int m_CounterValue=0;
    
    [BindFigmaButtonPress("AddButton")]
    public void IncrementNumber()
    {
        CounterText.text = (++m_CounterValue).ToString();
    }
}
