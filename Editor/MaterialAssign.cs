using UnityEngine;

[ExecuteInEditMode]
public class MaterialAssign : MonoBehaviour
{
    [SerializeField] Material Material;
    [SerializeField] GameObject Object;

    public void ChangeMaterial()
    {
        Renderer[] children;
        children = Object.GetComponentsInChildren<Renderer>();

        foreach (Renderer renderer in children)
        {
            Material[] materials = new Material[renderer.sharedMaterials.Length];
            for (int i = 0; i < renderer.sharedMaterials.Length; i++)
            {
                materials[i] = Material;
            }
            renderer.sharedMaterials = materials;
        }
    }
}
