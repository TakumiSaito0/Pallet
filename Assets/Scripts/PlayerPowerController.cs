using UnityEngine;

public class PlayerPowerController : MonoBehaviour
{
    public enum StateColor { White, Black }
    public enum PowerType { Red, Blue, Green, Yellow }

    private StateColor currentState = StateColor.White;

    void Update()
    {
        HandleStateSwitch();
        HandlePowerInput();
    }

    // TabÉLÅ[Ç≈îíÅ^çïÇÃêÿÇËë÷Ç¶
    void HandleStateSwitch()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            currentState = (currentState == StateColor.White) ? StateColor.Black : StateColor.White;
            Debug.Log("State switched to: " + currentState);
        }
    }

    // Z, X, C, VÇ≈ÇªÇÍÇºÇÍÇÃëÆê´Çî≠ìÆ
    void HandlePowerInput()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            ActivatePower(PowerType.Red);

        if (Input.GetKeyDown(KeyCode.X))
            ActivatePower(PowerType.Blue);

        if (Input.GetKeyDown(KeyCode.C))
            ActivatePower(PowerType.Green);

        if (Input.GetKeyDown(KeyCode.V))
            ActivatePower(PowerType.Yellow);
    }

    // é¿ç€Ç…óÕÇî≠ìÆÇ∑ÇÈèàóù
    void ActivatePower(PowerType type)
    {
        switch (currentState)
        {
            case StateColor.White:
                UseWhitePower(type);
                break;
            case StateColor.Black:
                UseBlackPower(type);
                break;
        }
    }

    // îíÇÃóÕÇî≠ìÆ
    void UseWhitePower(PowerType type)
    {
        switch (type)
        {
            case PowerType.Red:
                Debug.Log("Used WHITE RED power!");
                break;
            case PowerType.Blue:
                Debug.Log("Used WHITE BLUE power!");
                break;
            case PowerType.Green:
                Debug.Log("Used WHITE GREEN power!");
                break;
            case PowerType.Yellow:
                Debug.Log("Used WHITE YELLOW power!");
                break;
        }
    }

    // çïÇÃóÕÇî≠ìÆ
    void UseBlackPower(PowerType type)
    {
        switch (type)
        {
            case PowerType.Red:
                Debug.Log("Used BLACK RED power!");
                break;
            case PowerType.Blue:
                Debug.Log("Used BLACK BLUE power!");
                break;
            case PowerType.Green:
                Debug.Log("Used BLACK GREEN power!");
                break;
            case PowerType.Yellow:
                Debug.Log("Used BLACK YELLOW power!");
                break;
        }
    }
}
