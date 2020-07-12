using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedusaCommand : MonoBehaviour
{
    [SerializeField]
    private Direction directionJerryMoves = Direction.Up;
    
    [SerializeField]
    private float timeTillJerryActs = 0;

    [SerializeField]
    private bool onlyTriggerOnce = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            CommandJerry();

            if (onlyTriggerOnce)
            {
                Destroy(this);
            }
        }
    }

    public void CommandJerry() {
        Jerry.instance.StartCoroutine(JerryActs());
    }

    private IEnumerator JerryActs()
    {
        yield return new WaitForSecondsRealtime(timeTillJerryActs);

        switch (directionJerryMoves)
        {
            case Direction.Up:
                Jerry.instance.SetToRunSpeed();
                break;
            case Direction.Left:
                Jerry.instance.ChangeDirection("l");
                Jerry.instance.SetToRunSpeed();
                break;
            case Direction.Right:
                Jerry.instance.ChangeDirection("r");
                Jerry.instance.SetToRunSpeed();
                break;
        }
    }
}
