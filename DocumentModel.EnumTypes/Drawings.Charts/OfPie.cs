namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the OfPie enumeration.
/// Used in types such as OfPieChart.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.OfPieValues))]
public enum OfPie
{
  /// <summary>
  ///   Pie.
  /// </summary>
  [OpenXmlEnumValue("Pie")]
  Pie,
  /// <summary>
  ///   Bar.
  /// </summary>
  [OpenXmlEnumValue("Bar")]
  Bar
}

