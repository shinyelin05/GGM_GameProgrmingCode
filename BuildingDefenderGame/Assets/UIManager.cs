using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject uiWindow; // UI â�� ��Ÿ���� ���� ������Ʈ
    private bool isWindowOpen; // UI â�� ���� �ִ��� ����

    private void Start()
    {
        isWindowOpen = false;
        uiWindow.SetActive(false); // �ʱ⿡�� UI â�� ��Ȱ��ȭ ���·� ����
    }

    private void Update()
    {
        // UI â�� ���ų� �ݱ� ���� Ư�� Ű �Է��� �����մϴ�. ���÷δ� "P" Ű�� ����Ͽ����ϴ�.
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isWindowOpen)
                CloseUIWindow();
            else
                OpenUIWindow();
        }
    }

    private void OpenUIWindow()
    {
        uiWindow.SetActive(true);
        isWindowOpen = true;
    }

    private void CloseUIWindow()
    {
        uiWindow.SetActive(false);
        isWindowOpen = false;
    }
}
