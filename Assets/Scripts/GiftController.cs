using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftController : CollidableBase
{
    [SerializeField] private int m_life;
    public override void Slice(Vector3 _position, Vector3 _normalVector)
    {
        base.Slice(_position, _normalVector);
        m_gameManager.AddLife(m_life);
        gameObject.SetActive(false);
    }

    public override bool AllowsSlice()
    {
        return true;
    }
}
