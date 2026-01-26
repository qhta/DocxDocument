namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Defines the ShapeStyle Class.
/// </summary>
[OpenXmlType(typeof(DXO10DP.ShapeStyle))]
public partial class ShapeStyle : ModelElement<DXO10DP.ShapeStyle>
{
 /// <summary>
 ///   LineReference.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DP.ShapeStyle.LineReference))]
 [OpenXmlElement(typeof(DXO10DP.ShapeStyle))]
 public LineReference? LineReference { get => _LineReference; set => UpdateField(ref _LineReference, value, nameof(LineReference)); }

 private LineReference? _LineReference;
 /// <summary>
 ///   FillReference.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DP.ShapeStyle.FillReference))]
 [OpenXmlElement(typeof(DXO10DP.ShapeStyle))]
 public FillReference? FillReference { get => _FillReference; set => UpdateField(ref _FillReference, value, nameof(FillReference)); }

 private FillReference? _FillReference;
 /// <summary>
 ///   EffectReference.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DP.ShapeStyle.EffectReference))]
 [OpenXmlElement(typeof(DXO10DP.ShapeStyle))]
 public EffectReference? EffectReference { get => _EffectReference; set => UpdateField(ref _EffectReference, value, nameof(EffectReference)); }

 private EffectReference? _EffectReference;
 /// <summary>
 ///   Font Reference.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DP.ShapeStyle.FontReference))]
 [OpenXmlElement(typeof(DXO10DP.ShapeStyle))]
 public FontReference? FontReference { get => _FontReference; set => UpdateField(ref _FontReference, value, nameof(FontReference)); }

 private FontReference? _FontReference;
}