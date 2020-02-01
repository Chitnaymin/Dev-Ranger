using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private GameObject fireball;
    [SerializeField]
    private Transform firepoint;
    [SerializeField]
    [Range(0f, 1.5f)]
    private float firerate;
    [SerializeField]
    private GameObject hitVfx;


    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= firerate)
        {

            timer = 0f;
            weaponShoot();



        }

    }
    private void weaponShoot()
    {
        /*GameObject vfx = Instantiate(fireball, firepoint.position, Quaternion.identity);
        vfx.transform.localRotation = Quaternion.LookRotation(firepoint.forward);*/
        RaycastHit hit;
        if (Physics.Raycast(firepoint.position,firepoint.transform.forward,out hit,100f)) {
            Debug.Log(hit.transform.name);
            
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, hit.normal);
            
            GameObject vfx = Instantiate(hitVfx, hit.point, rot);
            Destroy(vfx, 3f);

        }

    }
}
