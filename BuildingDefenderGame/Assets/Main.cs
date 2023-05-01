using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public float radius = 5f; // 원의 반지름

    void Update()
    {
       if ( Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f; // z 축을 0으로 설정하여 2D 공간에서의 위치를 설정합니다.

            // 마우스 클릭 위치를 중심으로 하는 원 그리기
           // DrawCircle(mousePosition, radius);

            // 원 안에 있는 총알 삭제
            DestroyBulletsInCircle(mousePosition, radius);
        }
    }

    //private void DrawCircle(Vector3 center, float radius)
    //{
    //    int segments = 360; // 원을 근사하기 위한 세그먼트 수
    //    LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
    //    lineRenderer.startWidth = 0.1f;
    //    lineRenderer.endWidth = 0.1f;
    //    lineRenderer.positionCount = segments + 1;
    //    lineRenderer.useWorldSpace = false;

    //    float x;
    //    float y;
    //    float z = 0f;

    //    float angle = 20f;

    //    for (int i = 0; i <= segments; i++)
    //    {
    //        x = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
    //        y = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;

    //        lineRenderer.SetPosition(i, new Vector3(x, y, z) + center);

    //        angle += (360f / segments);
    //    }
    //    Destroy(lineRenderer);
    //}

    private void DestroyBulletsInCircle(Vector3 center, float radius)
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(center, radius);

        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Bullet"))
            {
                Destroy(collider.gameObject);
            }
        }
    }

}
