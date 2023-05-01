using UnityEngine;
using UnityEngine.UI;

public class ItemGenerator : MonoBehaviour
{
    public Button generateButton; // 생성 버튼
    public GameObject[] itemPrefabs; // 아이템 프리팹 배열

    public GameObject circle;


    public float timer; // 타이머 변수

    public MonoBehaviour targetScript;

    public Text yourText;

    private bool canPressButton = true;

    private int clickCount = 0;
    private int maxClickCount = 5;

    public Text randText;

    private void Start()
    {
        randText.text = "뽑기!, 5개 중 뽑기 사용 횟수는 : " + clickCount;
        yourText.gameObject.SetActive(false);
        generateButton.onClick.AddListener(GenerateItems);

        //UpdateButtonInteractable();
    }

    private void Update()
    {

        timer -= Time.deltaTime; // 타이머 감소

        if (timer <= 0f)
        {
            Time.timeScale = 1f;
            circle.SetActive(false); // 타이머 종료 시 게임 오브젝트를 비활성화
            targetScript.enabled = false;
            yourText.gameObject.SetActive(false);
        }

        if (Time.time >= 10f)
        {
            canPressButton = true;
           // UpdateButtonInteractable();
            TimeReset();
        }

        if (clickCount == 5)
        {
            randText.text = "뽑기 사용 가능 횟수를 소진하였습니다.";
        }

    }

    private void GenerateItems()
    {

        
        int randomIndex = Random.Range(0, itemPrefabs.Length); // 랜덤한 인덱스 선택
 
        yourText.gameObject.SetActive(true);

       // OnButtonClick();

        clickCount++;

        // 버튼 동작 코드
        Debug.Log(clickCount);

        // 버튼 클릭 후 버튼 상태 업데이트
        UpdateButtonInteractable2();

        if (randomIndex == 0)
        {
            circle.gameObject.SetActive(true);
            timer = 10f; // 타이머 초기화
            ChangeText("10초 동안 보호막이 활성화됩니다!");

        }
        else if (randomIndex == 1)
        {
            targetScript.enabled = true;
            timer = 10f;
            ChangeText("마우스 클릭으로 총알 삭제가 가능합니다!");

        }
        else if (randomIndex == 2)
        {
            Time.timeScale= 5f;
            circle.gameObject.SetActive(true);
            timer = 50f; // 타이머 초기화
            ChangeText("배속을 동반해 10초 동안 보호막이 활성화됩니다!");

        }



    }

    void ChangeText(string newText)
    {
        yourText.text = newText;
    }


    //// 버튼 클릭 시 실행될 함수
    //public void OnButtonClick()
    //{
    //    if (canPressButton)
    //    {
    //        // 버튼 동작 코드
    //        Debug.Log("Button Clicked!");

    //        // 버튼 클릭 후 버튼 상태 업데이트
    //        canPressButton = false;
    //        UpdateButtonInteractable();
    //    }
    //}

    //// 버튼 상태를 업데이트하는 함수
    //void UpdateButtonInteractable()
    //{
    //    generateButton.interactable = canPressButton;
    //}

    // 시간 리셋
    void TimeReset()
    {
    }
    void UpdateButtonInteractable2()
    {
        

        generateButton.interactable = clickCount < maxClickCount;
        randText.text = "5개 중 뽑기 사용 횟수는 : " + clickCount;

      
       
    }
}

