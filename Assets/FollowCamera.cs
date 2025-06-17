using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [Header("Takip edilecek obje")]
    [SerializeField] private Transform thingToFollow;
    [Header("Eğer Inspector boşsa bu tag'li objeyi bulacak")]
    [SerializeField] private string followTag = "Player";

    private void Awake()
    {
        // Inspector’dan atanmadıysa, sahnede tag’e göre bulmaya çalış
        if (thingToFollow == null)
        {
            GameObject target = GameObject.FindGameObjectWithTag(followTag);
            if (target != null)
                thingToFollow = target.transform;
            else
                Debug.LogError($"FollowCamera: '{followTag}' tag’li obje bulunamadı. Inspector’dan atama yapmayı unutma!");
        }
    }

    private void LateUpdate()
    {
        // Null kontrolü ile hatayı önlüyoruz
        if (thingToFollow == null) return;

        // Kamera, objenin pozisyonunu + (0,0,-10) olacak şekilde takip eder
        transform.position = thingToFollow.position + new Vector3(0f, 0f, -10f);
    }
}
