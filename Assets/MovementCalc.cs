using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCalc
{
    public Vector3 CalcMoveLeft(float moveSpeed)
    {
        return moveSpeed * Time.deltaTime * Vector3.left;
    }
    public Vector3 CalcMoveRight(float moveSpeed)
    {
        return moveSpeed * Time.deltaTime * Vector3.right;
    }
    public Vector3 CalcMoveBack(float moveSpeed)
    {
        return moveSpeed * Time.deltaTime * Vector3.back;
    }
    public Vector3 CalcMoveForward(float moveSpeed)
    {
        return moveSpeed * Time.deltaTime * Vector3.forward;
    }


}
