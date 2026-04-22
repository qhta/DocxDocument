namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Shape Style.
/// </summary>
[OpenXmlType(typeof(DXDD.Style))]
[XmlRoot("Style", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class Style : ModelElement<DXDD.Style>
{
 /// <summary>
 ///   LineReference.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Style.LineReference))]
 public LineReference? LineReference { get => _LineReference; set => UpdateField(ref _LineReference, value, nameof(LineReference)); }
 private LineReference? _LineReference;

 /// <summary>
 ///   FillReference.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Style.FillReference))]
 public FillReference? FillReference { get => _FillReference; set => UpdateField(ref _FillReference, value, nameof(FillReference)); }
 private FillReference? _FillReference;

 /// <summary>
 ///   EffectReference.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Style.EffectReference))]
 public EffectReference? EffectReference { get => _EffectReference; set => UpdateField(ref _EffectReference, value, nameof(EffectReference)); }
 private EffectReference? _EffectReference;

 /// <summary>
 ///   TextFormat Reference.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Style.FontReference))]
 public FontReference? FontReference { get => _FontReference; set => UpdateField(ref _FontReference, value, nameof(FontReference)); }
 private FontReference? _FontReference;
}