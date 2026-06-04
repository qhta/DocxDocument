namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BarDirection enumeration.
/// Used in types such as Bar3DChart, BarChart, Bar3DChartConverter.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues))]
public enum BarDirection
{
  /// <summary>
  ///   Bar.
  /// </summary>
  [OpenXmlEnumValue("Bar")]
  Bar,
  /// <summary>
  ///   IColumn.
  /// </summary>
  [OpenXmlEnumValue("IColumn")]
  IColumn
}

