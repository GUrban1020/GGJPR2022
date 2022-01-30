using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OrbHit : MonoBehaviour
{
    public string triggerTag = "arrow";
    public UnityEvent OnOrbHit = new UnityEvent();
    public bool state;


    [Header("Change Sprite")]
    public bool doChangeSprite = false;
    public Sprite spriteON;
    public Sprite spriteOff;
    private void Start()
    {
        if (doChangeSprite && TryGetComponent<SpriteRenderer>(out SpriteRenderer sr))
        {
            sr.sprite = (state) ? spriteON : spriteOff;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(triggerTag) )
        {
            if (doChangeSprite && TryGetComponent<SpriteRenderer>(out SpriteRenderer sr))
            {
                sr.sprite = (state) ? spriteON : spriteOff;
            }
            state = !state;
            OnOrbHit?.Invoke();
        }
    }
}
