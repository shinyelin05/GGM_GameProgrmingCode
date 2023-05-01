using UnityEngine;
using TMPro;

public class TextCloneManager : MonoBehaviour
{
    public TextMeshProUGUI textPrefab; // ������ �ؽ�Ʈ ������

    private TextMeshProUGUI clonedText; // ������ �ؽ�Ʈ

    private void Start()
    {
        // �ؽ�Ʈ �������� �����Ͽ� ������ �ؽ�Ʈ�� �����մϴ�.
        clonedText = Instantiate(textPrefab, transform);

        // ������ �ؽ�Ʈ�� ���� �����ɴϴ�.
        string textValue = clonedText.text;
        Debug.Log("Cloned Text Value: " + textValue);
    }
}
