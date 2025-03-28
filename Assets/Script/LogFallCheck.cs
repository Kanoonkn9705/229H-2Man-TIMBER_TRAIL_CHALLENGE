using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogFallCheck : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            GameManager.instance.LogFell(); // แจ้ง GameManager เมื่อไม้ตกพื้น
            Destroy(gameObject); // ลบไม้หลังตกพื้น (ถ้าต้องการ)
        }
    }
    
}
