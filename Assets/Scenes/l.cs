using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    GameObject obj;
    private float movePower = 1;
    private float moveSpeed = 6;
    public float jumPower = 5;
    private Animator anim;
    private bool D = false;
    private bool A = false;
    private SpriteRenderer PlayerSpriteRenderer;
    void Start()
    {
        obj = gameObject;
        anim = obj.GetComponent<Animator>();
        PlayerSpriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            D = true;
            A = false;

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            D = false;
        }

        if (D == true)
        {
            obj.transform.Translate(new Vector3(moveSpeed * Time.deltaTime * movePower, 0, 0));
            PlayerSpriteRenderer.flipX = false;
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            A = true;
            D = false;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            A = false;
        }

        if (A == true)
        {

            obj.transform.Translate(new Vector3(-moveSpeed * Time.deltaTime * movePower, 0, 0));

        }

    }
}
