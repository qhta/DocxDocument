namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
///   EffectReference in ChartsStyle extends EffectReference in Drawings with StyleColor.
/// </summary>
[OpenXmlType(typeof(DXO13DCS.EffectReference))]
[XmlRoot("EffectReference", Namespace = "DocumentModel.Drawings.ChartsStyle")]
public partial class EffectReference : DocumentModel.Drawings.EffectReference
{
 /// <summary>
 /// The style color for the effect reference, which can be used to specify a color from the chart's style. 
 /// </summary>
 [OpenXmlElement(typeof(DXO13DCS.StyleColor))]
 public StyleColor? StyleColor { get => _StyleColor; set => UpdateField(ref _StyleColor, value, nameof(StyleColor)); }
 private StyleColor? _StyleColor;
}