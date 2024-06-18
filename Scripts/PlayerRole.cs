using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRole : MonoBehaviour
{
    public bool isMurderer = false;
    private SpriteRenderer rend;
    public float proximityDistance = 2f; // Adjust this value as needed

    // Reference to the other SpriteRenderer object
    public SpriteRenderer otherSpriteRenderer;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (isMurderer)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Check proximity and destroy the other object
                if (otherSpriteRenderer != null &&
                    Vector3.Distance(transform.position, otherSpriteRenderer.transform.position) <= proximityDistance)
                {
                    Destroy(otherSpriteRenderer.gameObject);
                    SceneManager.LoadScene("Voting");
                }
            }
        }
    }
}