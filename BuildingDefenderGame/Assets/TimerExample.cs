using UnityEngine;
using UnityEngine.UI;

public class TimerExample : MonoBehaviour
{
    public Text timerText;
    private float timer;
    private bool isTimerRunning;

    void Start()
    {
        // 타이머 텍스트를 찾습니다.
        timerText = GetComponent<Text>();

        // 타이머 초기화
        timer = 0f;
        isTimerRunning = false;
    }

    void Update()
    {
        if (isTimerRunning)
        {
            // 타이머를 업데이트하고 텍스트로 출력합니다.
            timer += Time.deltaTime;
            timerText.text = FormatTime(timer);
        }
    }

    // 타이머를 시작합니다.
    public void StartTimer()
    {
        isTimerRunning = true;
    }

    // 타이머를 멈춥니다.
    public void StopTimer()
    {
        isTimerRunning = false;
    }

    // 타이머를 초기화합니다.
    public void ResetTimer()
    {
        timer = 0f;
        timerText.text = FormatTime(timer);
    }

    // 시간을 포맷하여 문자열로 반환합니다.
    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        int milliseconds = Mathf.FloorToInt((time * 100f) % 100f);

        return string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }
}
