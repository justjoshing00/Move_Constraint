using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand
{
    public void MoveLeft(Transform transform, int movementCapacity, System.Func<int> keyboardInput, System.Func<float,Vector3> calcMoveleft, float moveSpeed)
    {
        if (keyboardInput() == 1)
        {
            if (transform.position.x <= (movementCapacity * -1))
            {
                Debug.Log("cant move further");
                return;
            }
            transform.position += calcMoveleft(moveSpeed);
        }
    }

    public void  MoveRight(Transform transform, int movementCapacity, System.Func<int> keyboardInput, System.Func<float, Vector3> calcMoveRight, float moveSpeed)
    {
        if (keyboardInput() == 2)
        {
            if (transform.position.x >= movementCapacity)
            {
                Debug.Log("cant move further");
                return;
            }

            transform.position += calcMoveRight(moveSpeed);
        }
        
    }
    public void MoveForward(Transform transform, int movementCapacity,  System.Func<int> keyboardInput, System.Func<float, Vector3> calcMoveForward, float moveSpeed)
    {
        if (keyboardInput() == 3)
        {
            if (transform.position.z >= movementCapacity)
            {
                Debug.Log("cant move further");
                return;
            }
            transform.position += calcMoveForward(moveSpeed);
        }
        
    }
    public void MoveBack(Transform transform, int movementCapacity, System.Func<int> keyboardInput, System.Func<float, Vector3>calcMoveBack, float moveSpeed)
    {
        if (keyboardInput() == 4)
        {
            if (transform.position.z <= (movementCapacity * -1))
            {
                Debug.Log("cant move further");
                return;
            }
            transform.position += calcMoveBack(moveSpeed);
        }
        
    }
}
