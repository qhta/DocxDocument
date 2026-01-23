namespace DocumentModel.Vml;
/// <summary>
///   Shape Reference.
/// </summary>
public partial class Proxy : ModelElement<DXVO.Proxy>
{
    /// <summary>
    ///   Start Point Connection Flag
    /// </summary>
    public bool? Start { get => _Start; set => UpdateField(ref _Start, value, nameof(Start)); }

    private bool? _Start;
    /// <summary>
    ///   End Point Connection Flag
    /// </summary>
    public bool? End { get => _End; set => UpdateField(ref _End, value, nameof(End)); }

    private bool? _End;
    /// <summary>
    ///   Proxy Shape Reference
    /// </summary>
    public string? ShapeReference { get => _ShapeReference; set => UpdateField(ref _ShapeReference, value, nameof(ShapeReference)); }

    private string? _ShapeReference;
    /// <summary>
    ///   Connection Location
    /// </summary>
    public Int32? ConnectionLocation { get => _ConnectionLocation; set => UpdateField(ref _ConnectionLocation, value, nameof(ConnectionLocation)); }

    private Int32? _ConnectionLocation;
}