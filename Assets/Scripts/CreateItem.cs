﻿using UnityEngine;

public class CreateItem : MonoBehaviour {
    public GameObject item;
    public int cost = 100;
    private Vector3 screenPoint;
    private Vector3 offset;

    private void OnMouseDown () {
        if (Data.coin >= cost) {
            Debug.Log ("create iteme");
            GameObject _item = (GameObject) Instantiate (item, transform.position, Quaternion.identity);
            foreach (Behaviour childComponent in _item.GetComponentsInChildren<Behaviour> ())
                childComponent.enabled = false;
            screenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
            DragDrop dd = _item.GetComponent<DragDrop> ();
            dd.enabled = true;
            dd.screenPoint = screenPoint;
            dd.offset = offset;
            dd.cost = cost;
        } else {
            Debug.Log ("koin tidak cukup");
        }
    }
}