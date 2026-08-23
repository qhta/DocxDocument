namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
///    FillReference in ChartsStyle extends FillReference in Drawings with StyleColor.
/// </summary>
[OpenXmlType(typeof(DXO13DCS.FillReference))]
[DataContract]
[XmlRoot("FillReference", Namespace = "DocumentModel.Drawings.ChartsStyle")]
public partial class FillReference : DocumentModel.Drawings.FillReference
{
  /// <summary>
  /// The style color for the fill reference, which can be used to specify a color from the chart's style. 
  /// </summary>
  [OpenXmlElement(typeof(DXO13DCS.StyleColor))]
  public StyleColor? StyleColor { get => _StyleColor; set => UpdateField(ref _StyleColor, value, nameof(StyleColor)); }
  private StyleColor? _StyleColor;
}