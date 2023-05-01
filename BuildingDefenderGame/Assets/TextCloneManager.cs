using UnityEngine;
using TMPro;

public class TextCloneManager : MonoBehaviour
{
    public TextMeshProUGUI textPrefab; // 복제할 텍스트 프리팹

    private TextMeshProUGUI clonedText; // 복제된 텍스트

    private void Start()
    {
        // 텍스트 프리팹을 복제하여 복제된 텍스트를 생성합니다.
        clonedText = Instantiate(textPrefab, transform);

        // 복제된 텍스트의 값을 가져옵니다.
        string textValue = clonedText.text;
        Debug.Log("Cloned Text Value: " + textValue);
    }
}
