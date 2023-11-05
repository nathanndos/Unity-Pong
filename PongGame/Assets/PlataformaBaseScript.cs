using UnityEngine;

public abstract class PlataformaBaseScript : MonoBehaviour
{
    public float speed = 5f;
    public string axisMovimentation { get => isRight ? "Vertical" : "Vertical2"; }
    public abstract bool isRight { get; set; }

    public void setMovimentation() => transform.Translate(0f, Input.GetAxis(axisMovimentation) * speed * Time.deltaTime, 0f);
}
