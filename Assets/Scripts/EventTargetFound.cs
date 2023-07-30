using UnityEngine;

public class EventTargetFound : MonoBehaviour
{

    private TurnPokemon TurnPokemon;

    public void OnTargetFound()
    {
        TurnPokemon.Pokemon = gameObject;
    }

    public void OnTargetLost()
    {
        TurnPokemon.ResetScale();
        gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
}
