namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
///    LineReference in ChartsStyle extends LineReference in Drawings with StyleColor.
/// </summary>
[OpenXmlType(typeof(DXO13DCS.LineReference))]
[DataContract]
[XmlRoot("LineReference", Namespace = "DocumentModel.Drawings.ChartsStyle")]
public partial class LineReference : DocumentModel.Drawings.LineReference
{
  /// <summary>
  /// The style color for the line reference, which can be used to specify a color from the chart's style. 
  /// </summary>
  [OpenXmlElement(typeof(DXO13DCS.StyleColor))]
  public StyleColor? StyleColor { get => _StyleColor; set => UpdateField(ref _StyleColor, value, nameof(StyleColor)); }
  private StyleColor? _StyleColor;
}