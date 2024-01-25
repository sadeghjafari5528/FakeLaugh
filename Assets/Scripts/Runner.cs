using System.Collections;
using UnityEngine;

public class SpriteAnimation : MonoBehaviour
{
    public Sprite[] animationFrames;  // Array to hold your animation frames
    public float frameDuration = 0.1f; // Duration of each frame

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Start the animation coroutine
        StartCoroutine(PlayAnimation());
    }

    IEnumerator PlayAnimation()
    {
        while (true)
        {
            foreach (Sprite frame in animationFrames)
            {
                // Set the sprite renderer to the current frame
                spriteRenderer.sprite = frame;

                // Wait for the specified duration before showing the next frame
                yield return new WaitForSeconds(frameDuration);
            }
        }
    }
}
