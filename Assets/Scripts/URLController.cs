using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLController : MonoBehaviour
{
    public const string TALEEL1_URL = "https://moamen-aliiiiiiii.itch.io/taleel-1";
    public const string TALEEL2_URL = "https://moamen-aliiiiiiii.itch.io/taleel-2";
    public const string ZAHYA1_URL = "https://moamen-aliiiiiiii.itch.io/zahya-1";
    public const string ZAHYA2_URL = "https://moamen-aliiiiiiii.itch.io/zahya-2";

    public void OpenTaleel1_URL()
    { 
        Application.OpenURL(TALEEL1_URL );
    }

    public void OpenTaleel2_URL()
    {
        Application.OpenURL(TALEEL2_URL);
    }

    public void OpenZahyA1_URL()
    {
        Application.OpenURL(ZAHYA1_URL);
    }

    public void OpenZahyA2_URL()
    {
        Application.OpenURL(ZAHYA2_URL);
    }
}
