namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes style settings for a shape in chart drawings, including references to line, fill, effect, and font formatting.
/// </summary>
[OpenXmlType(typeof(DXDCD.Style))]
[DataContract]
[XmlRoot("Style", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public partial class Style: ModelElement<DXDCD.Style>
{
  /// <summary>
  /// Reference to the line formatting applied to the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.Style.LineReference))]
  public LineReference? LineReference
  {
    get => _LineReference ??= GetProperty<LineReference?>(GetUpdatableElement()?.LineReference);
    set => UpdateField(ref _LineReference, value, nameof(LineReference));
  }

  private LineReference? _LineReference;

  /// <summary>
  /// Reference to the fill formatting applied to the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.Style.FillReference))]
  public FillReference? FillReference
  {
    get => _FillReference ??= GetProperty<FillReference?>(GetUpdatableElement()?.FillReference);
    set => UpdateField(ref _FillReference, value, nameof(FillReference));
  }

  private FillReference? _FillReference;

  /// <summary>
  /// Reference to the effect formatting applied to the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.Style.EffectReference))]
  public EffectReference? EffectReference
  {
    get => _EffectReference ??= GetProperty<EffectReference?>(GetUpdatableElement()?.EffectReference);
    set => UpdateField(ref _EffectReference, value, nameof(EffectReference));
  }

  private EffectReference? _EffectReference;

  /// <summary>
  /// Reference to the font formatting applied to the shape's text content.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.Style.FontReference))]
  public FontReference? FontReference
  {
    get => _FontReference ??= GetProperty<FontReference?>(GetUpdatableElement()?.FontReference);
    set => UpdateField(ref _FontReference, value, nameof(FontReference));
  }

  private FontReference? _FontReference;
}