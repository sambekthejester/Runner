using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] PlayerInputCont player;
    [SerializeField] float lerpValue;
    private Vector3 playerxyz;

    private void LateUpdate()
    {
        setCameraLocation();
    }

    private void setCameraLocation()
    {


        Vector3 playerxyz = new Vector3(0, player.transform.position.y + 2.5f, player.transform.position.z - 3);

        transform.position = Vector3.Lerp(transform.position, playerxyz, lerpValue * Time.deltaTime);

    }
    public void nextLevel()
    {
        transform.position = new Vector3(0, 3, -24);
    }
}
