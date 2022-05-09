using UnityEngine;
using Zhdk.Gamelab;

public class ShowIdleTime : MonoBehaviour
{
    [SerializeField] public TextMesh text;
    [SerializeField] public Transform randomCube;

    private void Update()
    {
        text.text = AttractionScreen.Instance.IdleTime.ToString("F2") + " / " + AttractionScreen.Instance.IdleTimeLimit;
        randomCube.Rotate(Vector3.up, 1f);
    }
}
