using UnityEngine;

public class MoveCamera_new : MonoBehaviour {

    public Transform player;

    void Update() {
        transform.position = player.transform.position;
    }
}
