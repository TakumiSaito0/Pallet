using UnityEngine;

public class Player : MonoBehaviour
{
    public enum StateColor { White, Black }
    public enum PowerType { Red, Blue, Green, Yellow }

    private StateColor currentState = StateColor.White;

    void Update()
    {
        HandleStateSwitch();
        HandlePowerInput();
    }

    // Tabキーで白／黒の切り替え
    void HandleStateSwitch()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            currentState = (currentState == StateColor.White) ? StateColor.Black : StateColor.White;
            Debug.Log("State switched to: " + currentState);
        }
    }

    // Z, X, C, Vでそれぞれの属性を発動
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

    // 実際に力を発動する処理
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

    // 白の力を発動
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

    // 黒の力を発動
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