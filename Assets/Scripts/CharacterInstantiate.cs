using UnityEngine;

public class CharacterInstantiate : MonoBehaviour
{

    [SerializeField] GameObject unlockedCharacters;
    [SerializeField] GameObject lockedCharacters;
    [SerializeField] float unlockedamount;
    [SerializeField] float lockedamount;

    void Start()
    {
        InstantiateUnlocked();
        InstantiateLocked();
    }

    void InstantiateUnlocked()
    {
        for (var instanUnlocked = 0; instanUnlocked < unlockedamount; instanUnlocked++)
        {
            Instantiate(unlockedCharacters, transform);
        }
    }

    void InstantiateLocked()
    {
        for (var instanLocked = 0; instanLocked < lockedamount; instanLocked++)
        {
            Instantiate(lockedCharacters, transform);
        }
    }
}
