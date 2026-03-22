namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
///    FontReference in ChartsStyle extends FontReference in Drawings with StyleColor.
/// </summary>
[OpenXmlType(typeof(DXO13DCS.FontReference))]
public partial class FontReference : DocumentModel.Drawings.FontReference
{
  /// <summary>
  /// The style color for the font reference, which can be used to specify a color from the chart's style. 
  /// </summary>
  [OpenXmlElement(typeof(DXO13DCS.StyleColor))]
  public StyleColor? StyleColor { get => _StyleColor; set => UpdateField(ref _StyleColor, value, nameof(StyleColor)); }
  private StyleColor? _StyleColor;
}