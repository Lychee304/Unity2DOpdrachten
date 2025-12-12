using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    [SerializeField] private float _speed = 5;
    [SerializeField] private string _coinTag = "Coin";
    private int _coins = 0;
    private int _score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            print("waddup");
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += (new Vector3(0, 1, 0) * Time.deltaTime * _speed);
            transform.rotation = Quaternion.Euler(10, 0, 0);
            transform.localScale = new Vector3(2, 2, 2);
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("ahoy");
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += (new Vector3(-1, 0, 0) * Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            print("sup");
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += (new Vector3(0, -1, 0) * Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            print("dag");
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += (new Vector3(1, 0, 0) * Time.deltaTime * _speed);
        }
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.)
    }

    */



    // collider? i hardly know her

    private void OnCollisionEnter2D(Collision2D collision)
        {
        CoinValue coinValue;
        if (collision.gameObject.CompareTag(_coinTag) && collision.gameObject.TryGetComponent<CoinValue>(out coinValue))
        {
            _score += coinValue.GetScoreWorth();
            print("current score: " + _score);


            Destroy(collision.gameObject);
            _coins++;
            print("You now have " + _coins + " coins, hell yeah!");
        }
        
        // print(collision.gameObject.transform.position);
        }
}