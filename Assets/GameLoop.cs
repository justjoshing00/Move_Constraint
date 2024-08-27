using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    ConstrainedInput constrainedInput;
    MovementData movementData;
    MoveCommand moveCommand;
    MovementCalc movementCalc;

    [SerializeField] GameObject Sphere;

    // Start is called before the first frame update
    void Start()
    {
        Sphere = Instantiate(Resources.Load<GameObject>("Sphere"));
        constrainedInput = new();
        movementData = new();
        moveCommand = new();
        movementCalc = new();
    }

    // Update is called once per frame
    void Update()
    {
        //move system
        moveCommand.MoveLeft(Sphere.transform, movementData.MovementCapacity, constrainedInput.KeyboardInput, movementCalc.CalcMoveLeft, movementData.MoveSpeed);
        moveCommand.MoveRight(Sphere.transform, movementData.MovementCapacity, constrainedInput.KeyboardInput, movementCalc.CalcMoveRight, movementData.MoveSpeed);
        moveCommand.MoveForward(Sphere.transform, movementData.MovementCapacity, constrainedInput.KeyboardInput, movementCalc.CalcMoveForward, movementData.MoveSpeed);
        moveCommand.MoveBack(Sphere.transform, movementData.MovementCapacity, constrainedInput.KeyboardInput, movementCalc.CalcMoveBack, movementData.MoveSpeed);

    }
}
