using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField]
    float speed = 10.0f;
    public float offsetRepeat = 0.0f;

    [SerializeField]
    GameObject[] panel = new GameObject[2];
    int panelPosition = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        Move();
        MoveOnOffsetReached();
    }

    void Move() {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * horizontal * Time.deltaTime * -speed;
        offsetRepeat += horizontal;
    }

    void MoveOnOffsetReached() {
        if(offsetRepeat > 200.0f) {
            panel[panelPosition].transform.localPosition += new Vector3(80.0f, 0.0f, 0.0f);
            offsetRepeat = 0.0f;
            ++panelPosition;
        }

        if (panelPosition >= panel.Length) {
            panelPosition = 0;
        }
    }
}
