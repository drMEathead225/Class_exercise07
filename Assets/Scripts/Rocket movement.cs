using UnityEngine;
using UnityEngine.InputSystem;

public class Rocketmovement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;
    [SerializeField] float minX = -5f;
    [SerializeField] float maxX = 5f;

    Vector2  moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Onmove(InputValue value) 
    {
        moveInput = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
