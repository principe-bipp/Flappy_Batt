using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject obstaclePrefab;//Objstaculo que vai ser spawnado
    public float spawnInterval = 2f;//Intervalo entre cada spawn
    public Vector3 spawnPosition = new Vector3(14f, -2f, 0f);//Posição aonde ele vai ser spawnado
    private float timer;//Contador do intervalo

    //dificuldade do game
    public float MaximoY = -0.1f;
    public float MinimoY = -3f;

    private void Update()
    {
        if (Playercontroller.Instance.gameStarted) 
        {
            timer -= Time.deltaTime;//Contador do intervalo
            if (timer <= 0f)
            {
                SpawnObstacle();//Método logo abaixo
                timer = spawnInterval;//Reseta o contador
            }
        }

        
    }

    void SpawnObstacle()
    {
        spawnPosition.y = Random.Range(MinimoY, MaximoY);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);//Instancia o obstáculo na posição definida
    }
}