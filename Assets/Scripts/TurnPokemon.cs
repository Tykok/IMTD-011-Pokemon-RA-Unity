using UnityEngine;
using Button = UnityEngine.UI.Button;

public class TurnPokemon : MonoBehaviour
{

    public GameObject Pokemon;
    public Button BtnUp;
    public Button BtnDown;

    void Start()
    {
        BtnUp.onClick.AddListener(BtnUpPress);
        BtnDown.onClick.AddListener(BtnDownPress);
    }

    void BtnUpPress()
    {
        if (Pokemon != null)
        {
            Pokemon.transform.localScale = Pokemon.transform.localScale * 1.1f;
        }
    }

    void BtnDownPress()
    {
        if(Pokemon != null)
        {
            Pokemon.transform.localScale = Pokemon.transform.localScale * 0.9f;
        }
    }

    public void ResetScale()
    {
        Pokemon.transform.localScale = new Vector3(1, 1, 1);
    }
}
