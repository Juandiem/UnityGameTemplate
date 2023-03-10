using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomCharacter : MonoBehaviour
{
    public GameObject prefab;
    public Transform[] spawnPoints;
    [SerializeField]
    string[] traitsTags;

    int numChildren, randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        //NOTA: no lo he hecho bucle para que se vea como construye el personaje poco a poco
        for(int i = 0; i < spawnPoints.Length; i++)
        {
            GameObject character = Instantiate(prefab, spawnPoints[i].transform);

            //Pelo
            Transform hair = character.transform.Find("Customization/Hair");

            // Check if the child GameObject was found
            if (hair != null)
            {
                numChildren = hair.transform.childCount;
                if (numChildren > 0)
                {
                    randomIndex =Random.Range(-1, numChildren);
                    if (randomIndex > -1)
                        hair.transform.GetChild(randomIndex).gameObject.SetActive(true);
                    else Debug.Log("CALVO");
                }
            }
            //Barba&Bigote
            Transform beard = character.transform.Find("Customization/Beards");

            // Check if the child GameObject was found
            if (beard != null)
            {
                numChildren = beard.transform.childCount;
                if (numChildren > 0)
                {
                    randomIndex = Random.Range(-1, numChildren);
                    if (randomIndex > -1)
                        beard.transform.GetChild(randomIndex).gameObject.SetActive(true);
                }
            }
            //Sombreros
            Transform hat = character.transform.Find("Customization/Hats");

            // Check if the child GameObject was found
            if (hat != null)
            {
                numChildren = hat.transform.childCount;
                if (numChildren > 0)
                {
                    randomIndex = Random.Range(-1, numChildren);
                    if (randomIndex > -1)
                        hat.transform.GetChild(randomIndex).gameObject.SetActive(true);
                }
            }
            //Pecho
            Transform chest = character.transform.Find("Armors/Chests");

            // Check if the child GameObject was found
            if (chest != null)
            {
                numChildren = chest.transform.childCount;
                if (numChildren > 0)
                {
                    randomIndex = Random.Range(-1, numChildren);
                    if (randomIndex > -1)
                        chest.transform.GetChild(randomIndex).gameObject.SetActive(true);
                }
            }
            //Pantalones
            Transform pants = character.transform.Find("Armors/Pants");

            // Check if the child GameObject was found
            if (pants != null)
            {
                numChildren = pants.transform.childCount;
                if (numChildren > 0)
                {
                    randomIndex = Random.Range(-1, numChildren);
                    if (randomIndex > -1)
                        pants.transform.GetChild(randomIndex).gameObject.SetActive(true);
                }
            }
            //Zapatos
            Transform boots = character.transform.Find("Armors/Boots");

            // Check if the child GameObject was found
            if (boots != null)
            {
                numChildren = boots.transform.childCount;
                if (numChildren > 0)
                {
                    randomIndex = Random.Range(-1, numChildren);
                    if (randomIndex > -1)
                        boots.transform.GetChild(randomIndex).gameObject.SetActive(true);
                }
            }
            //Accesorios
            Transform accesories = character.transform.Find("Armors/Accesories");

            // Check if the child GameObject was found
            if (accesories != null)
            {
                numChildren = accesories.transform.childCount;
                if (numChildren > 0)
                {
                    randomIndex = Random.Range(-1, numChildren);
                    if (randomIndex > -1)
                        accesories.transform.GetChild(randomIndex).gameObject.SetActive(true);
                }
            }
        }
    }

}
