using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public bool ClickedSpace;
    public bool Touching;
    public KeyCode Arrow;
    public KeyCode Letter;
    public GameObject Player;
    public AudioSource OnHit;
    private bool Playing;

    // Update is called once per frame
    void Start()
    {
        Playing = false;
        //yield return new WaitForSecondsRealtime(0.90f);
        //OnHit.Play();
    }

    void Update()
    {
        if ((Input.GetKeyDown(Arrow) || Input.GetKeyDown(Letter)) && Touching)
        {
            if (!Playing){
                OnHit.Play();
                Playing = true;
            }
            StartCoroutine(ClickedSpaceAtTheMoment());
        }
        if ((Input.GetKeyDown(Arrow) || Input.GetKeyDown(Letter)) && !Touching)
        {
            Player.GetComponent<Health>().CurrentHealth -= 1;
        }
    }
    IEnumerator ClickedSpaceAtTheMoment()
    {
        ClickedSpace = true;
        yield return new WaitForSecondsRealtime(0.05f);
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