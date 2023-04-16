//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//namespace runner.Obstacle
//{
//    public class CreateObstacle : MonoBehaviour
//    {
//        [SerializeField] GameObject obstacle;
//        [SerializeField] float maxTime;
//        [SerializeField] float minTime;
//        [SerializeField] float currentTime;
//        [SerializeField] float timeBoundary;
//        [SerializeField] PlayerInputCont player;
//        [SerializeField] int maxPosx=4;
//        [SerializeField] int minPosx=-4;
//        [SerializeField] int currentPosx;
//        [SerializeField] int maxUnit = 9;
//        [SerializeField] int currentUnit;

//        private void Update()
//        {
//            currentTime += Time.deltaTime;
//            if (currentTime > timeBoundary)
//            {
//                SpawnObstacle();
//                ResetTime();
//            }
//        }

//        private void SpawnObstacle()
//        {
//            GameObject poolEnemy = obstaclePool.Instance.Get();
//            if (setPosition().Length>0)
//            {

//                foreach (var item in setPosition())
//                {
//                    poolEnemy.transform.position = item;
//                    poolEnemy.gameObject.SetActive(true);
//                }


//            }
//        }
//        private void ResetTime()
//        {
//            currentTime = 0f;
//            timeBoundary = Random.Range(minTime, maxTime);

//        }
//        private Vector3[] setPosition()
//        {
//            currentUnit = Random.Range(0, maxUnit);
//            for (int i = 0; i < currentUnit; i++)
//            {
//                Vector3[] enemyPositionArray;
//                currentPosx= Random.Range(minPosx, maxPosx)
//                Vector3 enemyPosition = new Vector3(currentPosx, player.transform.position.y, 5);





//                return enemyPositionArray;

//            }




//        }


//    }
//}
