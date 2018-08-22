using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieroScript : MonoBehaviour {

    public Transform target;  // ターゲットへの参照
    private Vector3 offset;  // 相対座標
    private Animator anim;

    void Start()
    {
        //自分自身とtargetとの相対距離を求める
        offset = GetComponent<Transform>().position - target.position;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // 自分自身の座標に、targetの座標に相対座標を足した値を設定する
        GetComponent<Transform>().position = target.position + offset;

        if (Input.GetKey("up"))
        {
            anim.SetBool("rolling", true);
        }
        else
        {
            anim.SetBool("rolling", false);
        }

        if (Input.GetKey("right"))
        {
            anim.SetBool("right", true);
        }
        else
        {
            anim.SetBool("right", false);
        }

        if (Input.GetKey("left"))
        {
            anim.SetBool("left", true);
        }
        else
        {
            anim.SetBool("left", false);
        }

        if (Input.GetKey("down"))
        {
            anim.SetBool("back", true);
        }
        else
        {
            anim.SetBool("back", false);
        }
    }
}
