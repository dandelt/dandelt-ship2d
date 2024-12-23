using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : DanMonoBehaviour
{
    [SerializeField] static protected GameCtrl instance;
    public static GameCtrl Instance => instance;

    [SerializeField] protected Transform mainCam;
    public Transform MainCam => mainCam;

    protected override void Awake()
    {
        base.Awake();
        if (GameCtrl.instance != null) Debug.LogError("Only 1 GameManager allow to exist");
        GameCtrl.instance = this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if (mainCam != null) return;
        this.mainCam = GameObject.FindObjectOfType<Camera>().transform;
        Debug.Log(transform.name + ": LoadCamera", gameObject);
    }
}
