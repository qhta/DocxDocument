namespace DocumentModel.Vml;
/// <summary>
///   Shape Grouping Types
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.EditAsValues))]
public enum EditAs
{
  /// <summary>
  ///   Shape Canvas.
  /// </summary>
  Canvas,
  /// <summary>
  ///   Organization Chart Diagram.
  /// </summary>
  OrganizationChart,
  /// <summary>
  ///   Radial Diagram.
  /// </summary>
  Radial,
  /// <summary>
  ///   Cycle Diagram.
  /// </summary>
  Cycle,
  /// <summary>
  ///   Pyramid Diagram.
  /// </summary>
  Stacked,
  /// <summary>
  ///   Venn Diagram.
  /// </summary>
  Venn,
  /// <summary>
  ///   Bullseye Diagram.
  /// </summary>
  Bullseye
}