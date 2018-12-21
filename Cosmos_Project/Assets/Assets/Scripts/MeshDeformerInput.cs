using UnityEngine;

public class MeshDeformerInput : MonoBehaviour {
	
	public float force = 10f;
	public float forceOffset = 0.1f;
    public ParticleSystem particlesystem;
    public ParticleSystem particlesystem1;
    public ParticleSystem particlesystem2;
    public ParticleSystem particlesystem3;
    public ParticleSystem particlesystem4;
    public ParticleSystem particlesystem5;
    public ParticleSystem particlesystem6;
    //private LineRenderer lineRenderer;

    void Start()
    {
        particlesystem = this.GetComponentInChildren<ParticleSystem>();
        //lineRenderer = this.GetComponent<Renderer>() as LineRenderer;
    }

    void Update () {
		if (Input.GetMouseButton(0)) {
			HandleInput();
            
            
        }
	}

	void HandleInput () {
        


        Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		if (Physics.Raycast(inputRay, out hit)) {
			MeshDeformer deformer = hit.collider.GetComponent<MeshDeformer>();
			if (deformer) {
                particlesystem.transform.position = hit.point;
                particlesystem.Play();             
                Vector3 point = hit.point;
				point += hit.normal * forceOffset;
				deformer.AddDeformingForce(point, force);
                //deformer.Addparticles(point);
            }
		}
	}
}