using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public Camera mainCam;
    public BoxCollider2D topWall;
    public BoxCollider2D bottomWall;
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;

    public Transform player1;
    public Transform player2;

    public float wallSize;
    public float paddleDistance;

    void Update()
    {
        // placed in update, to handle dynamic screen size changes
        topWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f)).x * 2f + wallSize * 2, wallSize);
        topWall.transform.position = new Vector3(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height)).y + wallSize / 2);

        bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f)).x * 2f + wallSize * 2, wallSize);
        bottomWall.transform.position = new Vector3(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, 0f)).y - wallSize / 2);

        leftWall.size = new Vector2(wallSize, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height)).y * 2);
        leftWall.transform.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f)).x - wallSize / 2, 0f);

        rightWall.size = new Vector2(wallSize, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height)).y * 2);
        rightWall.transform.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f)).x + wallSize / 2, 0f);

        float player1y = player1.transform.position.y;
        player1.transform.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f)).x + paddleDistance, player1y);

        float player2y = player2.transform.position.y;
        player2.transform.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f)).x - paddleDistance, player2y);
    }
}
