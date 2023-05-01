using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject uiWindow; // UI 창을 나타내는 게임 오브젝트
    private bool isWindowOpen; // UI 창이 열려 있는지 여부

    private void Start()
    {
        isWindowOpen = false;
        uiWindow.SetActive(false); // 초기에는 UI 창을 비활성화 상태로 설정
    }

    private void Update()
    {
        // UI 창을 열거나 닫기 위해 특정 키 입력을 감지합니다. 예시로는 "P" 키를 사용하였습니다.
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
