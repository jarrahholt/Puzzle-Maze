using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public float speed;
    public GameObject[] row1;
    public GameObject[] row2;
    public GameObject[] row3;
    public GameObject[] row4;
    public GameObject[] row5;

    private bool row1Full;
    private bool row2Full;
    private bool row3Full;
    private bool row4Full;
    private bool row5Full;

    private float rowChooser;
    private int pieceChooser;
    private Rigidbody rb;
    private float rowLength;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        row1Full = false;
        row2Full = false;
        row3Full = false;
        row4Full = false;
        row5Full = false;

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
    void Update()
    {
      
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        chooseRowAgain:
            rowChooser = Random.Range(1, 5);
            //			Debug.Log ("Row " + rowChooser);

            if (rowChooser == 1 && row1Full == false)
            {
            choosePieceAgain1:
                pieceChooser = Random.Range(0,4);
                if (pieceChooser == 0 && row1[pieceChooser].activeInHierarchy == false)
                {
                    row1[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 1 && row1[pieceChooser].activeInHierarchy == false)
                {
                    row1[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 2 && row1[pieceChooser].activeInHierarchy == false)
                {
                    row1[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 3 && row1[pieceChooser].activeInHierarchy == false)
                {
                    row1[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 4 && row1[pieceChooser].activeInHierarchy == false)
                {
                    row1[pieceChooser].SetActive(true);
                }
                
                else if (row1[0].activeInHierarchy == false && row1[1].activeInHierarchy == false && row1[2].activeInHierarchy == false && row1[3].activeInHierarchy == false && row1[4].activeInHierarchy == false)
                {
                    row1Full = true;
                }
                else {
                    goto choosePieceAgain1;
                }
            }
            else if (rowChooser == 2 && row2Full == false)
            {
            choosePieceAgain2:
                pieceChooser = Random.Range(0, 4);
                if (pieceChooser == 0 && row2[pieceChooser].activeInHierarchy == false)
                {
                    row2[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 1 && row2[pieceChooser].activeInHierarchy == false)
                {
                    row2[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 2 && row2[pieceChooser].activeInHierarchy == false)
                {
                    row2[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 3 && row2[pieceChooser].activeInHierarchy == false)
                {
                    row2[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 4 && row2[pieceChooser].activeInHierarchy == false)
                {
                    row2[pieceChooser].SetActive(true);
                }
                else if (row2[0].activeInHierarchy == false && row2[1].activeInHierarchy == false && row2[2].activeInHierarchy == false && row2[3].activeInHierarchy == false && row2[4].activeInHierarchy == false)
                {
                    row1Full = true;
                }
                else {
                    goto choosePieceAgain2;
                }
            }
            else if (rowChooser == 3 && row3Full == false)
            {
            choosePieceAgain3:
                pieceChooser = Random.Range(0, 4);
                if (pieceChooser == 0 && row3[pieceChooser].activeInHierarchy == false)
                {
                    row3[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 1 && row3[pieceChooser].activeInHierarchy == false)
                {
                    row3[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 2 && row3[pieceChooser].activeInHierarchy == false)
                {
                    row3[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 3 && row3[pieceChooser].activeInHierarchy == false)
                {
                    row3[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 4 && row3[pieceChooser].activeInHierarchy == false)
                {
                    row3[pieceChooser].SetActive(true);
                }
                
                else if (row3[0].activeInHierarchy == false && row3[1].activeInHierarchy == false && row3[2].activeInHierarchy == false && row3[3].activeInHierarchy == false && row3[4].activeInHierarchy == false)
                {
                    row3Full = true;
                }
                else {
                    goto choosePieceAgain3;
                }
            }
            else if (rowChooser == 4 && row4Full == false)
            {
            choosePieceAgain4:
                pieceChooser = Random.Range(0, 4);
                if (pieceChooser == 0 && row4[pieceChooser].activeInHierarchy == false)
                {
                    row4[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 1 && row4[pieceChooser].activeInHierarchy == false)
                {
                    row4[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 2 && row4[pieceChooser].activeInHierarchy == false)
                {
                    row4[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 3 && row4[pieceChooser].activeInHierarchy == false)
                {
                    row4[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 4 && row4[pieceChooser].activeInHierarchy == false)
                {
                    row4[pieceChooser].SetActive(true);
                }
                else if (row4[0].activeInHierarchy == false && row4[1].activeInHierarchy == false && row4[2].activeInHierarchy == false && row4[3].activeInHierarchy == false && row4[4].activeInHierarchy == false)
                {
                    row1Full = true;
                }
                else {
                    goto choosePieceAgain4;
                }
            }
            else if (rowChooser == 5 && row5Full == false)
            {
            choosePieceAgain5:
                pieceChooser = Random.Range(0, 4);
                if (pieceChooser == 0 && row5[pieceChooser].activeInHierarchy == false)
                {
                    row4[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 1 && row5[pieceChooser].activeInHierarchy == false)
                {
                    row4[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 2 && row5[pieceChooser].activeInHierarchy == false)
                {
                    row4[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 3 && row5[pieceChooser].activeInHierarchy == false)
                {
                    row4[pieceChooser].SetActive(true);
                }
                else if (pieceChooser == 4 && row5[pieceChooser].activeInHierarchy == false)
                {
                    row5[pieceChooser].SetActive(true);
                }
                else if (row5[0].activeInHierarchy == false && row5[1].activeInHierarchy == false && row5[2].activeInHierarchy == false && row5[3].activeInHierarchy == false && row5[4].activeInHierarchy == false)
                {
                    row1Full = true;
                }
                else {
                    goto choosePieceAgain5;
                }
            }
            else if (row1Full == true && row2Full == true && row3Full == true && row4Full == true && row5Full == true)
            {
                //Application.LoadLevel("Success");
            }
            else {
                goto chooseRowAgain;
            }
        }
    }
}