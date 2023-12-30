using UnityEngine;

public class PlayerPositionSaver : MonoBehaviour
{
    public static Vector3 lastPlayerPosition; // SampleScene'deki son pozisyonu saklamak için

    public void SavePlayerPosition(Vector3 position)
    {
        lastPlayerPosition = position; // Player pozisyonunu sakla
    }
}
