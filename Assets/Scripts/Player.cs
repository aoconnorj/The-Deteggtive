using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        float speedModifier = 3f;
        
        float walkSpeedLeftRight = Input.GetAxisRaw("Horizontal") * speedModifier;
        float walkSpeedUpDown = Input.GetAxisRaw("Vertical") * speedModifier;

        transform.position += new Vector3(walkSpeedLeftRight * Time.deltaTime, walkSpeedUpDown * Time.deltaTime, 0);
    }
}
