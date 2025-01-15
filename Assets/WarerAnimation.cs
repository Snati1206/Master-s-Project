using UnityEngine;

public class WarerAnimation : MonoBehaviour
{
    public Material waterMaterial;
    public float waveSpeed = 0.01f;

    void Update()
    {
        if (waterMaterial != null)
        {
            float offset = Time.time * waveSpeed;
            waterMaterial.SetTextureOffset("_MainTex" , new Vector2(offset, offset));
        }
    }   
}
