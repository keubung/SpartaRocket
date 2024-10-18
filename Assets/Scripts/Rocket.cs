using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    protected Vector3 rocket_y;

    protected Rigidbody2D _rb2d;

    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }
}
