using UnityEngine;

public class PlataformaScript : PlataformaBaseScript
{
    public bool fieldIsRight;
    public override bool isRight
    {
        get => fieldIsRight;
        set => value = fieldIsRight;
    }

    void Update()
    {
        setMovimentation();
    }
}
