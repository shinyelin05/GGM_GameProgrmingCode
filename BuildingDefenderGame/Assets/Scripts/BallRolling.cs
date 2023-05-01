using UnityEngine;

public class BallRolling : MonoBehaviour
{
    public float speed = 3f; // 공의 속도
    public Transform buildingTransform; // 빌딩의 위치

    private Rigidbody2D rigidbody2d;
    private Transform targetTransform;

    private float lookForTargetTimer;
    private float lookForTargetTimerMax = .2f;

    private HealthSystem healthSystem;


    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

        // 공의 초기 위치를 랜덤하게 설정
        transform.position = new Vector2(Random.Range(-42f, 42f), 25f);

        rigidbody2d = GetComponent<Rigidbody2D>();
        targetTransform = BuildingManager.Instance.GetHQBuilding()?.transform;
        lookForTargetTimer = Random.Range(0f, lookForTargetTimerMax);
        healthSystem = GetComponent<HealthSystem>();
       // healthSystem.OnDamaged += HealthSystem_OnDamaged;
    }

    private void FixedUpdate()
    {
        // 빌딩의 위치로 향하는 방향 벡터 계산
        Vector2 direction = (buildingTransform.position - transform.position).normalized;

        rigidbody2d.velocity = direction * speed;
    }


    private void HealthSystem_OnDamaged(object sender, System.EventArgs e)
    {
        CinemachineShake.Instance.ShakeCamera(5f, .1f);
        ChromaticAberrationEffect.Instance.SetWeight(.5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        FlashlightEffect();
    }

    public SpriteRenderer flashlightSprite; // 섬광 스프라이트
    public float flashlightRadius = 5f; // 섬광의 반지름

    void FlashlightEffect()
    {
        flashlightSprite.transform.position = new Vector3(0,0,0);
       
        flashlightSprite.gameObject.SetActive(true);

    }
}
