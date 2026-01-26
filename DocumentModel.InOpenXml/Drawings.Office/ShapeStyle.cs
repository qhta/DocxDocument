namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the ShapeStyle Class.
/// </summary>
[OpenXmlType(typeof(DXOD.ShapeStyle))]
public partial class ShapeStyle : ModelElement<DXOD.ShapeStyle>
{
 /// <summary>
 ///   LineReference.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.ShapeStyle.LineReference))]
 /// <summary>
 ///   LineReference.
 /// </summary>
 [OpenXmlElement(typeof(DXOD.ShapeStyle))]
 public LineReference? LineReference { get => _LineReference; set => UpdateField(ref _LineReference, value, nameof(LineReference)); }

 private LineReference? _LineReference;
 /// <summary>
 ///   FillReference.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.ShapeStyle.FillReference))]
 /// <summary>
 ///   FillReference.
 /// </summary>
 [OpenXmlElement(typeof(DXOD.ShapeStyle))]
 public FillReference? FillReference { get => _FillReference; set => UpdateField(ref _FillReference, value, nameof(FillReference)); }

 private FillReference? _FillReference;
 /// <summary>
 ///   EffectReference.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.ShapeStyle.EffectReference))]
 /// <summary>
 ///   EffectReference.
 /// </summary>
 [OpenXmlElement(typeof(DXOD.ShapeStyle))]
 public EffectReference? EffectReference { get => _EffectReference; set => UpdateField(ref _EffectReference, value, nameof(EffectReference)); }

 private EffectReference? _EffectReference;
 /// <summary>
 ///   Font Reference.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.ShapeStyle.FontReference))]
 /// <summary>
 ///   Font Reference.
 /// </summary>
 [OpenXmlElement(typeof(DXOD.ShapeStyle))]
 public FontReference? FontReference { get => _FontReference; set => UpdateField(ref _FontReference, value, nameof(FontReference)); }

 private FontReference? _FontReference;
}