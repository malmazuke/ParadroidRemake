using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    public GameObject innerDoor;
    
    int playersInRange = 0;
    
    void OnTriggerEnter (Collider other) {
        if (other.tag != "Player") {
            return;
        }

        playersInRange++;
        if (playersInRange > 0) {
            OpenDoor ();
        }
    }

    void OnTriggerExit (Collider other) {
        if (other.tag != "Player") {
            return;
        }

        playersInRange--;
        if (playersInRange <= 0) {
            playersInRange = 0;
            CloseDoor ();
        }
    }

    void OpenDoor () {
        if (innerDoor.activeSelf) {
            innerDoor.SetActive (false);
        }
    }

    void CloseDoor () {
        innerDoor.SetActive (true);
    }
}
