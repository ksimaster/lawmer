using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnScript : MonoBehaviour
{
    public GameObject [] monsters = new GameObject[2];
    public Camera cam;
    public GameObject CameraPoint; // ������ �� ������
    public GameObject SpawnPoint; // ����� ������
    public GameObject panelGameOver;
    public GameObject buttonRing;

    // private float speedSpawn; //�������� ������

    public float minX, minY, minZ; // ����������� ���� ��������� � ������ ��������� ����� ������
    public float maxX, maxY, maxZ; // ������������ ���� ��������� � ������ ��������� ����� ������

    public int countMonster;
    public Text textCountMonster;
    private int i;

    private void Start()
    {
        textCountMonster.text = "�������� ��������: " + countMonster.ToString();
        
    }

    private void Update()
    {
        if (ColllisionDead.buttonCount)
        {
            buttonRing.SetActive(true);
            ColllisionDead.buttonCount = false;
        }
    }

    public void SpawnMonster()
    {
        cam.transform.position = CameraPoint.transform.position; //new Vector3(0, 23.1f, 118.1f);
        cam.transform.rotation = CameraPoint.transform.rotation; //new Quaternion(0f, Mathf.PI, 0f, 0f);
        if (countMonster > 0)
        {
            i = Random.Range(0, 2);
            float x = Random.Range(minX, maxX) + SpawnPoint.transform.position.x; // ������� X
            float y = Random.Range(minY, maxY) + SpawnPoint.transform.position.y; // ������� Y
            float z = Random.Range(minZ, maxZ) + SpawnPoint.transform.position.z; // ������� Z
            Instantiate(monsters[i], new Vector3(x, y, z), transform.rotation);
            countMonster--;
            textCountMonster.text = "�������� ��������: " + countMonster.ToString();
            buttonRing.SetActive(false);
        }
        else
        {
            buttonRing.SetActive(false);
            panelGameOver.SetActive(true);
        }
    }


    
}
