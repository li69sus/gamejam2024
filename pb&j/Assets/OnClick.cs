using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public bool ClickedSpace;
    public bool Touching;
    public KeyCode Arrow;
    public GameObject Player;
    public AudioSource OnHit;

    // Update is called once per frame
    IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(0.05f);
        OnHit.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(Arrow) && Touching)
        {
            StartCoroutine(ClickedSpaceAtTheMoment());
        }
        if (Input.GetKeyDown(Arrow) && !Touching)
        {
            Player.GetComponent<Health>().CurrentHealth -= 1;
        }
    }
    IEnumerator ClickedSpaceAtTheMoment()
    {
        ClickedSpace = true;
        yield return new WaitForSecondsRealtime(0.01f);
        ClickedSpace = false;
    }

private void OnTriggerStay2D(Collider2D collision)
{
    Touching = true;
    if (ClickedSpace)
    {
        Destroy(collision.gameObject);
    }
}

private void OnTriggerExit2D(Collider2D collision)
{
    Touching = false;
}
}
