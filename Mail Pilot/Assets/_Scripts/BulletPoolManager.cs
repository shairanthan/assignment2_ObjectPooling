using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;

    //TODO: create a structure to contain a collection of bullets
    public int counter; //keeps count of the amount / size of the queue 
    public Queue<GameObject> poolList = new Queue<GameObject>(); //actual queue of bullets 
 

    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pools
       
        for (int i = 0; i < counter; i++)
        {
            GameObject obj = Instantiate(bullet);
            obj.SetActive(false);
            poolList.Enqueue(obj); //creates queue of object(bullets) and sets them to inactive 
        }
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {
        GameObject objectToSpawn = poolList.Dequeue(); //return bullets in front of the queue
        objectToSpawn.SetActive(true);
        return objectToSpawn;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        bullet.SetActive(false);
        poolList.Enqueue(bullet); //this code - once the previous one becomes inactive, we add another bullet to the queue 

    }
}
