using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputCont : MonoBehaviour
{
    private float _horizontal;
    public float HorizontalValue => _horizontal;
    private void Update()
    {
        GetHoriztonalInput();

    }
    private void GetHoriztonalInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved && Mathf.Abs(touch.deltaPosition.x) < 80)
            {

                _horizontal = touch.deltaPosition.x;
            }
            else
            {
                _horizontal = 0;

            }

        }



    }
}
