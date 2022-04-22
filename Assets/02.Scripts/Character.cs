using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CharacterType
{
    HAIR,
    EYE,
    ONEPIECE
}

public class Character : MonoBehaviour
{
    public static Character instance;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }
    }

    void Update()
    {

    }
}
