using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItemController : MonoBehaviour
{
  [SerializeField] private bool door = false;
  [SerializeField] private bool Key = false;
  [SerializeField] private KeyInventory _keyInventory = null;

  private KeyDoorController doorObject;

  private void Start()
  {
    if (door)
    {
        doorObject = GetComponent<KeyDoorController>();
    }
  }
    public void ObjectInteraction()
        {
            if(door)
            {
              doorObject.PlayAnimation();

            }
            
            else if (Key)
            {
              _keyInventory.hasKey = true;
              gameObject.SetActive(false);
            }
        }

}
