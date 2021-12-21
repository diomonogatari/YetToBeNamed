using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private Transform transformPlayer;
    [SerializeField]
    private float velocityX = 0.2f;

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        MoveCharacter();
    }


    //Detect input
    private void MoveCharacter()
    {
        // Input.GetAxis();
        transformPlayer.position += new Vector3(velocityX, 0, 0);
    }
}