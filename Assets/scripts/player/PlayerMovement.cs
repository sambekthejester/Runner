using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _vSpeed = 1f;
    [SerializeField] float _hSpeed = 1f;
    [SerializeField] PlayerInputCont _inputCont;
    private float hValue;
    private float _newPos;
    public int isinc = 0;

    private void Update()
    {

        GameManager.Instance.IncreaseScore();

    }
    private void FixedUpdate()
    {

        moveForward();
        moveHorizontal();
        HorizontalDead();

    }
    private void moveForward()
    {
        transform.Translate(Vector3.forward * _vSpeed * Time.fixedDeltaTime);
        IncreaseSpeed();


        //  Debug.Log(_vSpeed);
    }

    private void moveHorizontal()
    {


        hValue = _inputCont.HorizontalValue;

        _newPos = transform.position.x + hValue * Time.fixedDeltaTime * _hSpeed;
        transform.position = new Vector3(_newPos, transform.position.y, transform.position.z);


    }

    private void HorizontalDead()
    {
        if (transform.position.x > 4 || transform.position.x < -4)
        {
            _inputCont.enabled = false;
            GameManager.Instance.GameOver();
            Debug.Log("gameover");
        }
    }

    private void IncreaseSpeed()
    {
        int score = Mathf.CeilToInt(GameManager.Instance.ScoreTimerFunc());

        if (score % 5 == 0 && score != 0)
        {
            isinc++;

            if (isinc % 50 == 0)
            {
                Debug.Log(score);
                _vSpeed += 1f;

            }


        }
    }

    public void nextSpeed()
    {
        _vSpeed = 0;
        _vSpeed = 13;
    }

}
