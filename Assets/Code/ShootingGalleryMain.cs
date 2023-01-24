using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingGalleryMain : MonoBehaviour
{
    [SerializeField]
    private Transform targetPrefab;
    [SerializeField]
    private int targetCount = 10;
    private List<Transform> targets = new List<Transform>();
    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < targetCount; i++)
        {
           Transform newTarget = Instantiate(targetPrefab);
            targets.Add(newTarget);
        }

        
    }

    // Update is called once per frame
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit rch;

        if (Physics.Raycast(ray, out rch))
        {
            Debug.Log("Bonk!");
        }

        rch.transform
    }
}
