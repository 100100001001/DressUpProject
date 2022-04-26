using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType
{
    HAIR,
    EYE,
    TOP,
    BOTTOM,
    ONEPIECE,
    HAT,
    GLASSES,
    EARRING,
    NECKLACE,
    SHOES,
    SOCKS
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

    //void Update()
    //{

    //}

}
