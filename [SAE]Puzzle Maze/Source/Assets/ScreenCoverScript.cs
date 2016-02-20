using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ScreenCoverScript : MonoBehaviour {

	public GameObject[] row1;
	public GameObject[] row2;
	public GameObject[] row3;
	public GameObject[] row4;

	private bool row1Full;
	private bool row2Full;
	private bool row3Full;
	private bool row4Full;

	private float rowChooser;
	private int pieceChooser;
	private int rowLength;


	// Use this for initialization
	void Start () {
		row1Full = false;
		row2Full = false;
		row3Full = false;
		row4Full = false;
		rowLength = row1.Length;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Jump")) {
		chooseRowAgain:
			rowChooser = Random.Range(1,5);
//			Debug.Log ("Row " + rowChooser);

			if (rowChooser == 1 && row1Full == false) {
			choosePieceAgain1:
					pieceChooser = Random.Range(0,rowLength);
				if(pieceChooser == 0 && row1[pieceChooser].activeInHierarchy == false){
					row1[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 1 && row1[pieceChooser].activeInHierarchy == false){
					row1[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 2 && row1[pieceChooser].activeInHierarchy == false){
					row1[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 3 && row1[pieceChooser].activeInHierarchy == false){
					row1[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 4 && row1[pieceChooser].activeInHierarchy == false){
					row1[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 5 && row1[pieceChooser].activeInHierarchy == false){
					row1[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 6 && row1[pieceChooser].activeInHierarchy == false){
					row1[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 7 && row1[pieceChooser].activeInHierarchy == false){
					row1[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 8 && row1[pieceChooser].activeInHierarchy == false){
					row1[pieceChooser].SetActive(true);
				}
				else if(row1[0].activeInHierarchy == false && row1[1].activeInHierarchy == false && row1[2].activeInHierarchy == false && row1[3].activeInHierarchy == false && row1[4].activeInHierarchy == false && row1[5].activeInHierarchy == false && row1[6].activeInHierarchy == false && row1[7].activeInHierarchy == false && row1[8].activeInHierarchy == false){
					row1Full = true;
				}
				else {
					goto choosePieceAgain1;
				}
			}
		    else if (rowChooser == 2 && row2Full == false) {
			choosePieceAgain2:
					pieceChooser = Random.Range(0,rowLength);
				if(pieceChooser == 0 && row2[pieceChooser].activeInHierarchy == false){
					row2[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 1 && row2[pieceChooser].activeInHierarchy == false){
					row2[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 2 && row2[pieceChooser].activeInHierarchy == false){
					row2[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 3 && row2[pieceChooser].activeInHierarchy == false){
					row2[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 4 && row2[pieceChooser].activeInHierarchy == false){
					row2[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 5 && row2[pieceChooser].activeInHierarchy == false){
					row2[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 6 && row2[pieceChooser].activeInHierarchy == false){
					row2[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 7 && row2[pieceChooser].activeInHierarchy == false){
					row2[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 8 && row2[pieceChooser].activeInHierarchy == false){
					row2[pieceChooser].SetActive(true);
				}
				else if(row2[0].activeInHierarchy == false && row2[1].activeInHierarchy == false && row2[2].activeInHierarchy == false && row2[3].activeInHierarchy == false && row2[4].activeInHierarchy == false && row2[5].activeInHierarchy == false && row2[6].activeInHierarchy == false && row2[7].activeInHierarchy == false && row2[8].activeInHierarchy == false){
					row2Full = true;
				}
				else {
					goto choosePieceAgain2;
				}
			}
			else if (rowChooser == 3 && row3Full == false) {
			choosePieceAgain3:
					pieceChooser = Random.Range(0,rowLength);
				if(pieceChooser == 0 && row3[pieceChooser].activeInHierarchy == false){
					row3[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 1 && row3[pieceChooser].activeInHierarchy == false){
					row3[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 2 && row3[pieceChooser].activeInHierarchy == false){
					row3[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 3 && row3[pieceChooser].activeInHierarchy == false){
					row3[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 4 && row3[pieceChooser].activeInHierarchy == false){
					row3[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 5 && row3[pieceChooser].activeInHierarchy == false){
					row3[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 6 && row3[pieceChooser].activeInHierarchy == false){
					row3[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 7 && row3[pieceChooser].activeInHierarchy == false){
					row3[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 8 && row3[pieceChooser].activeInHierarchy == false){
					row1[pieceChooser].SetActive(true);
				}
				else if(row3[0].activeInHierarchy == false && row3[1].activeInHierarchy == false && row3[2].activeInHierarchy == false && row3[3].activeInHierarchy == false && row3[4].activeInHierarchy == false && row3[5].activeInHierarchy == false && row3[6].activeInHierarchy == false && row3[7].activeInHierarchy == false && row3[8].activeInHierarchy == false){
					row3Full = true;
				}
				else {
					goto choosePieceAgain3;
				}
			}
			else if (rowChooser == 4 && row4Full == false) {
			choosePieceAgain4:
					pieceChooser = Random.Range(0,rowLength);
				if(pieceChooser == 0 && row4[pieceChooser].activeInHierarchy == false){
					row4[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 1 && row4[pieceChooser].activeInHierarchy == false){
					row4[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 2 && row4[pieceChooser].activeInHierarchy == false){
					row4[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 3 && row4[pieceChooser].activeInHierarchy == false){
					row4[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 4 && row4[pieceChooser].activeInHierarchy == false){
					row4[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 5 && row4[pieceChooser].activeInHierarchy == false){
					row4[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 6 && row4[pieceChooser].activeInHierarchy == false){
					row4[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 7 && row4[pieceChooser].activeInHierarchy == false){
					row4[pieceChooser].SetActive(true);
				}
				else if(pieceChooser == 8 && row4[pieceChooser].activeInHierarchy == false){
					row4[pieceChooser].SetActive(true);
				}
				else if(row4[0].activeInHierarchy == false && row4[1].activeInHierarchy == false && row4[2].activeInHierarchy == false && row4[3].activeInHierarchy == false && row4[4].activeInHierarchy == false && row4[5].activeInHierarchy == false && row4[6].activeInHierarchy == false && row4[7].activeInHierarchy == false && row4[8].activeInHierarchy == false){
					row4Full = true;
				}
				else {
					goto choosePieceAgain4;
				}
			}
			else if (row1Full == true && row2Full == true && row3Full == true && row4Full == true){
				SceneManager.LoadScene("Success");
			}
			else {
				goto chooseRowAgain;
			}

		}
		if (Input.GetButtonUp ("Jump")) {}
	}
}
