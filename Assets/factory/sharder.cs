using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharder : MonoBehaviour
{
	void Update()
	{
		RaycastHit[] hits;
		hits = Physics.RaycastAll(transform.position, transform.forward, 100.0F);
		int i = 0;
		while (i < hits.Length)
		{
			RaycastHit hit = hits[i];
			Renderer renderer = hit.collider.GetComponent<Renderer>();
			if (renderer)
			{
				renderer.material.shader = Shader.Find("Transparent/Diffuse");
				renderer.material.color = new Color(renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, 0.4f);

			}
			i++;
		}
	}
}