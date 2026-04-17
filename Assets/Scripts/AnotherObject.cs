using UnityEngine;

public class AnotherObject : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log($"PersistentObject.staticPublicDebugText = {PersistentObject.stati}");
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            PersistentObject.staticPublicDebugText = "B";

        }
        else if (Input.GetKeyDown(KeyCode.C))
        {

            PersistentObject.SetStaticPrivateText("C");

        }
        else if (Input.GetKeyDown(KeyCode.D))

        {

            var go = GameObject.Find("PersistentObject");

            var p = go.GetComponent<PersistentObject>();

            p.SetInstancePrivateText("D");

        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            PersistentObject.GetInstance().SetStaticPrivateText("D");
        }

    }
}
 