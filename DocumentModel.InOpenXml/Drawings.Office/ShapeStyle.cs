namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the ShapeStyle Class.
/// </summary>
public partial class ShapeStyle : ModelElement<DXOD.ShapeStyle>
{
    /// <summary>
    ///   LineReference.
    /// </summary>
    public LineReference? LineReference { get => _LineReference; set => UpdateField(ref _LineReference, value, nameof(LineReference)); }

    private LineReference? _LineReference;
    /// <summary>
    ///   FillReference.
    /// </summary>
    public FillReference? FillReference { get => _FillReference; set => UpdateField(ref _FillReference, value, nameof(FillReference)); }

    private FillReference? _FillReference;
    /// <summary>
    ///   EffectReference.
    /// </summary>
    public EffectReference? EffectReference { get => _EffectReference; set => UpdateField(ref _EffectReference, value, nameof(EffectReference)); }

    private EffectReference? _EffectReference;
    /// <summary>
    ///   Font Reference.
    /// </summary>
    public FontReference? FontReference { get => _FontReference; set => UpdateField(ref _FontReference, value, nameof(FontReference)); }

    private FontReference? _FontReference;
}