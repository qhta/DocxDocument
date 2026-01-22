namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Defines the ShapeStyle Class.
/// </summary>
public partial class ShapeStyle : ModelElement<DXO10DP.ShapeStyle>
{
    /// <summary>
    ///   LineReference.
    /// </summary>
    public LineReference? LineReference { get => _LineReference; set => UpdateField(ref _LineReference, value, nameof(LineReference)); }

    private LineReference? _LineReference;
    /// <summary>
    ///   FillReference.
    /// </summary>
    public FillReference? FillReference { get; set; }
    /// <summary>
    ///   EffectReference.
    /// </summary>
    public EffectReference? EffectReference { get; set; }
    /// <summary>
    ///   Font Reference.
    /// </summary>
    public FontReference? FontReference { get; set; }
}