using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_control : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Vector3 BaseSize = new Vector3(1f, 1f, 1f);
    public Vector3 NewColor;
    public Color BaseColor;
    public Material material;

    private Renderer rend;

    private float OldR;
    private float OldG;
    private float OldB;




    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null && renderer.material != null)
        {
            // Asigna el nuevo color al material.
            renderer.material.color = BaseColor;

        }
        rend = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale = BaseSize;
        ///NewTransform(NewSize);
    }

    public void C_UniformScale(float FloatSize)
    {
        Debug.Log("extOSC float reciver" + FloatSize);
        Vector3 vectorUNIscale = new Vector3(FloatSize, FloatSize, FloatSize);
        Debug.Log("Vector desde floatOSC" + vectorUNIscale);
        transform.localScale = vectorUNIscale;
    }

    public void C_rotator_to_vector2(Vector2 XYcoords)
    {

        Debug.Log("extOSC V2 reciver" + XYcoords);
        Vector3 vector2to3 = new Vector3(XYcoords.y, XYcoords.x, 0.0f);
        Debug.Log("Vector desde floatOSC" + vector2to3);
        transform.eulerAngles = vector2to3 * 360.0f;
    }

    public void C_floats_to_colorR(float NR)
    {
        Debug.Log("extOSC RED reciver:" + NR);
        OldG = NewColor.y;
        OldB = NewColor.z;
        NewColor = new Vector3(NR,OldG,OldB);
        Debug.Log("NuevoColor" + NewColor);



        Color colorfinal = new Color(NewColor.x, NewColor.y, NewColor.z);

        Debug.Log("ColorFlinal" + colorfinal);

        rend.material.color = colorfinal;
    }

    public void C_floats_to_colorG(float NG)
    {
        Debug.Log("extOSC GREEN reciver" + NG);

        OldR = NewColor.x;
        OldB = NewColor.z;
        NewColor = new Vector3(OldR, NG, OldB);
        Debug.Log("NuevoColor" + NewColor);

        Color colorfinal = new Color(NewColor.x, NewColor.y, NewColor.z);

        Debug.Log("ColorFlinal" + colorfinal);

        rend.material.color = colorfinal;

    }

    public void C_floats_to_colorB(float NB)
    {
        Debug.Log("extOSC BLUE reciver" + NB);
        OldR = NewColor.x;
        OldG = NewColor.y;
        NewColor = new Vector3(OldR, OldG, NB);
        Debug.Log("NuevoColor" + NewColor);

        Color colorfinal = new Color(NewColor.x, NewColor.y, NewColor.z);

        Debug.Log("ColorFlinal" + colorfinal);

        rend.material.color = colorfinal;
    }


}
