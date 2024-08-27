using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstrainedInput
{
public int KeyboardInput()
    // if im slightly ahead of where i should be, thats probably a bug.
    {
        if (Input.GetKey(KeyCode.A))
        {
            return 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            return 2;
        }
        if (Input.GetKey(KeyCode.W))
        {
            return 3;
        }
        if (Input.GetKey(KeyCode.S))
        {
            return 4;
        }
        return 0;
    }
}
