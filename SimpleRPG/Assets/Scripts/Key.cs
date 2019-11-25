using UnityEngine;
using System;
public class Key : MonoBehaviour
{

    public event Action OnContact = delegate { };

    public enum KeyColor{blue};

    public KeyColor keycolor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnContact.Invoke();
        Destroy(gameObject);
    }

}
