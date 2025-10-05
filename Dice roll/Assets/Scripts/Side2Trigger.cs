using UnityEngine;

//TODO: Создать один скрипт для проверки стороны, вместо шести одинаковых на каждую сторону
public class Side2Trigger : MonoBehaviour
{
    private bool isDiceStopped = false;
    private bool isCounted = false;
    
    void IsDiceStopped()
    {
        this.isDiceStopped = true;
    }
    
    void OnEnable()
    {
        EventDiceStopManager.OnDiceStoppedEvent += IsDiceStopped;
    }
    
    void OnDisable()
    {
        EventDiceStopManager.OnDiceStoppedEvent -= IsDiceStopped;
    }
    
    void OnTriggerStay(Collider other)
    {
        if (this.isDiceStopped && !this.isCounted)
        {
            if (other.CompareTag("Ground"))
            {
                Debug.Log("Score is 5");
                this.isCounted = true;
            }
        }
    }
}