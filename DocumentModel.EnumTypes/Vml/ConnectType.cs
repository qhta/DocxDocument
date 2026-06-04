namespace DocumentModel.Vml;
/// <summary>
///   Connection Locations Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.ConnectValues))]
public enum ConnectType
{
  /// <summary>
  ///   No.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.ConnectValues.None))]
  None,
  /// <summary>
  ///   Four Connections.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.ConnectValues.Rectangle))]
  Rectangle,
  /// <summary>
  ///   Edit Point Connections.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.ConnectValues.Segments))]
  Segments,
  /// <summary>
  ///   Custom Connections.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.ConnectValues.Custom))]
  Custom
}