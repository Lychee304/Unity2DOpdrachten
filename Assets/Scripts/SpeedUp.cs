using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float GetPlayerSpeed()
    {
        return _speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
