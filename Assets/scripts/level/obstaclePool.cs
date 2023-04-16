//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//namespace runner.Obstacle
//{
//    public class obstaclePool : MonoBehaviour
//    {
//        [SerializeField] GameObject prafabs;
//        [SerializeField] int countLoop = 10;
//        Queue<GameObject> _poolPrefabs = new Queue<GameObject>();
//        public static obstaclePool Instance { get; private set; }
//        private void Awake()
//        {
//            SingletonObject();
//        }

//        private void Start()
//        {

//            GrowPoolPrefab();
//        }
//        public GameObject Get()
//        {
//            if (_poolPrefabs.Count == 0)
//            {
//                GrowPoolPrefab();
//            }
//            return _poolPrefabs.Dequeue();
//        }

//        private void GrowPoolPrefab()
//        {
//            for (int i = 0; i < countLoop; i++)
//            {
//                GameObject newPrefab = Instantiate(prafabs);
//                newPrefab.transform.parent = this.transform;
//                newPrefab.gameObject.SetActive(false);
//                _poolPrefabs.Enqueue(newPrefab);
//            }
//        }

//        public void Set(GameObject poolObject)
//        {
//            poolObject.gameObject.SetActive(false);
//            _poolPrefabs.Enqueue(poolObject);
//        }
//        private void SingletonObject()
//        {
//            if (Instance == null)
//            {
//                Instance = this;
//                DontDestroyOnLoad(this.gameObject);
//            }
//            else
//            {
//                Destroy(this.gameObject);
//            }
//        }


//    }


//}
