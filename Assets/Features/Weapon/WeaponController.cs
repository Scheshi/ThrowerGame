using Features.Player;
using Features.Voids;
using UnityEngine;


namespace Features.Weapon
{
    public class WeaponController: MonoBehaviour
    {
        [SerializeField] private Rigidbody rigidbody;
        [SerializeField] private Collider collider;
        [SerializeField] private WeaponData data;
        private bool _isThrowing;

        public bool IsTrowing => _isThrowing;

        private void Start()
        {
            collider.isTrigger = true;
            rigidbody.isKinematic = true;
        }

        public void Pickup(bool isPickup)
        {
            rigidbody.constraints = isPickup ? RigidbodyConstraints.FreezePosition : RigidbodyConstraints.None;
            rigidbody.isKinematic = false;
        }
        
        public void Throw(Vector3 lookDirection, float throwForce)
        {
            _isThrowing = true;
            rigidbody.AddForce(lookDirection.normalized * throwForce, ForceMode.Impulse);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.transform.TryGetComponent<IFloor>(out _))
            {
                rigidbody.isKinematic = true;
                _isThrowing = false;
                Vector3 position = transform.position;
                position.y += 0.05f;
                transform.position = position;
            }
            else if (_isThrowing && other.transform.TryGetComponent(out IDamagable damagable))
            {
                damagable.Damage(data.Damage, data.IsArmorIgnore);
            }
        }
    }
}