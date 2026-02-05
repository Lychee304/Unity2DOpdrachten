using UnityEngine;
using UnityEngine.UI;

public class LevelGen : MonoBehaviour
{
    [SerializeField] private GameObject _CollisionWall;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(-6, 3, 0);
        transform.localScale = new Vector3(8, 3, 0);

        Instantiate(_CollisionWall, transform.position, transform.localScale);
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
