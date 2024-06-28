using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_main : MonoBehaviour
{
    public Transform[] robot_spawn_points;
    public Transform robot_current_spawn_point;
    public Transform player_transform;
    public int roobt_current_spawn_point_count;
    public Animator robot_animator;

    public GameObject robot_ball;
    public Transform robot_fire_transform;
    public float ball_destroy_second;


    public float ball_fire_now;
    public float ball_fire_max;

    void Start()
    {

    }


    void Update()
    {
        ball_fire_now += Time.deltaTime;
        if(ball_fire_now > ball_fire_max) 
        {
            fire();
            ball_fire_now = 0f;
        }
    }

    public void spawn()
    {
        roobt_current_spawn_point_count++;
        robot_current_spawn_point = robot_spawn_points[roobt_current_spawn_point_count];
        transform.position = robot_current_spawn_point.position;
    
    }

    void fire() 
    {
        robot_fire_transform.LookAt(player_transform);
        GameObject _ball = Instantiate(robot_ball, robot_fire_transform.position, robot_fire_transform.rotation);
        Destroy(_ball, ball_destroy_second);
    }

    



}
