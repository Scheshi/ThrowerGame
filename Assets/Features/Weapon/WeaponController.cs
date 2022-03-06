using UnityEngine;

namespace Features.Weapon
{
    public class WeaponController: MonoBehaviour
    {
        [SerializeField] private Rigidbody rigidbody;

        public void Pickup(bool isPickup)
        {
            rigidbody.isKinematic = isPickup;
        }
        
        public void Throw(Vector3 lookDirection, float throwForce)
        {
            rigidbody.AddForce(lookDirection.normalized * throwForce);
        }
    }
}