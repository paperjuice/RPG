using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    mc_behaviour mc_behaviour;

    [SerializeField]
    float offset_x = 0.0f;
    [SerializeField]
    float offset_y = 0.0f;

    private void Awake() {
        mc_behaviour = GameObject.FindObjectOfType<mc_behaviour>();
    }

    void Start() {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Follow();        
    }

    void Follow() {
        Vector3 target_position =  new Vector3(
            mc_behaviour.transform.position.x +  offset_x,
            mc_behaviour.transform.position.y + offset_y,
            this.transform.position.z
            );
        Vector3 current_position = transform.position;

        transform.position = Vector3.Lerp(current_position, target_position, Time.deltaTime * 2.0f);
    }
}
