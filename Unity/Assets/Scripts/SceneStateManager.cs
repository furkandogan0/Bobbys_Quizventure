using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateManager : MonoBehaviour
{
    public static SceneStateManager instance; // Singleton instance
    [System.Serializable]
    public class ObjectState
    {
        public GameObject gameObject;
        public Vector3 position;
        public Quaternion rotation;
        // Daha fazla durum bilgisi eklemek isterseniz buraya ekleyebilirsiniz
    }

    public List<ObjectState> enemyStates = new List<ObjectState>();
    public List<ObjectState> chestStates = new List<ObjectState>();

    public float playerHealth; // Ana karakterin can durumu

    public void SaveSceneState()
    {
        enemyStates.Clear();
        chestStates.Clear();

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject[] chests = GameObject.FindGameObjectsWithTag("Chest");
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        foreach (GameObject enemy in enemies)
        {
            ObjectState enemyState = new ObjectState();
            enemyState.gameObject = enemy;
            enemyState.position = enemy.transform.position;
            enemyState.rotation = enemy.transform.rotation;

            enemyStates.Add(enemyState);
        }

        foreach (GameObject chest in chests)
        {
            ObjectState chestState = new ObjectState();
            chestState.gameObject = chest;
            chestState.position = chest.transform.position;
            chestState.rotation = chest.transform.rotation;

            chestStates.Add(chestState);
        }

        if (player != null)
        {
            ObjectState playerState = new ObjectState();
            playerState.gameObject = player;
            playerState.position = player.transform.position;
            playerState.rotation = player.transform.rotation;

            PlayerManager playerManager = player.GetComponent<PlayerManager>(); // PlayerManager bileþenini doðru þekilde al
            if (playerManager != null)
            {
                playerHealth = playerManager.health; // PlayerManager bileþenindeki can deðerini al
            }
        }
    }

    public void RestoreSceneState()
    {
        RestoreObjectStates(enemyStates);
        RestoreObjectStates(chestStates);

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            PlayerManager playerManager = player.GetComponent<PlayerManager>(); // PlayerManager bileþenini doðru þekilde al
            if (playerManager != null)
            {
                playerManager.health = playerHealth; // PlayerManager bileþenine can deðerini geri yükle
            }
        }
    }

    private void RestoreObjectStates(List<ObjectState> objectStates)
    {
        foreach (ObjectState state in objectStates)
        {
            if (state.gameObject != null)
            {
                state.gameObject.transform.position = state.position;
                state.gameObject.transform.rotation = state.rotation;
                // Gerekli diðer durumlarý geri yükleme
            }
        }
    }
}
