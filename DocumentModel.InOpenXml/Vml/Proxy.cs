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
    public bool? End { get; set; }
    /// <summary>
    ///   Proxy Shape Reference
    /// </summary>
    public string? ShapeReference { get; set; }
    /// <summary>
    ///   Connection Location
    /// </summary>
    public Int32? ConnectionLocation { get; set; }
}