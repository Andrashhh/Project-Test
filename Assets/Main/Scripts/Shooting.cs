using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Shooting : MonoBehaviour
{
    [SerializeField] bool _IsShooting = true;
    [SerializeField] float _ShootInterval = 1f;
    float _ShootLast;

    public GameObject Projectile;

    private void Update() {
        Shoot();
    }

    void Shoot() {
        if(_IsShooting) {
            if(_ShootLast < _ShootInterval) {
                _ShootLast += Time.deltaTime;
                return;
            }
            _ShootLast = 0f;
            InitPrefab();
        }

    }
    void InitPrefab() {
        var obj = Instantiate(Projectile, transform);
        obj.transform.rotation = transform.rotation;
        Destroy(obj, 5f);
    }
}
