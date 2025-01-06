using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float move_distance = 15.0f; // 발판 최대이동값
    float moved_distance = 0.0f; // move_distance 만큼 움직인 값을 다시 0으로 바꾸고 다시 move_distance만큼 움직였을 때를 체크하기 위해 존재
    Vector2 move_dir = Vector2.right;
    public float speed = 0.5f;

    void Update()
    {
        // 움직이려는 방향 벡터에 속력값을 곱해주면 이번 Frame에 이동할 거리와 방향이 나옴
        // 계산 결과를 transform.position 현재 위치에 더해주면 이동 한 후의 위치 값이 new_pos 에 저장된다.
        Vector2 new_pos = (Vector2)transform.position + (move_dir * speed);
        transform.position = new_pos;
        moved_distance += 0.05f;

        if(moved_distance >= move_distance)
        {
            moved_distance = 0.0f;
            if(move_dir == Vector2.right)
            {
                move_dir = Vector2.left;
            }
            else if(move_dir == Vector2.left)
            {
                move_dir = Vector2.right;
            }
        }
    }
}
