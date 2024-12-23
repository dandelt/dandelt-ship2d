using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    protected static InputManager instance;
    public static InputManager Instance => instance;

    [SerializeField] protected Vector3 mousePos;
    public Vector3 MousePos => mousePos;
    
    [SerializeField] protected float onFiring;
    public float OnFiring => onFiring;

    private void Awake()
    {
        if (InputManager.instance != null) Debug.LogWarning("Only 1 InputManager allow to exist");
        InputManager.instance = this;
    }
    protected void FixedUpdate()
    {
        this.GetMouseDown();
        this.GetMousePos();
    }

    protected virtual void GetMousePos()
    {
        this.mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    protected virtual void GetMouseDown()
    {
        this.onFiring = Input.GetAxis("Fire1");
    }
}
