using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class CameraEffect : MonoBehaviour {
    Material material;
	
	void Awake () {
        material = new Material(Shader.Find("Hidden/Shader"));
	}

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material);
    }
}
