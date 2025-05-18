using System.Runtime.InteropServices;
using UnityEngine;

public class WebLinker : MonoBehaviour
{
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void OpenInNewTab(string url);
#endif

    public void OpenURL(string url)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        OpenInNewTab(url);
#else
        Application.OpenURL(url);
#endif
    }
}
