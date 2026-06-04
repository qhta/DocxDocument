namespace DocumentModel.Vml;
/// <summary>
///   Connector Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.ConnectorValues))]
public enum ConnectorType
{
  /// <summary>
  ///   No Connector.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.ConnectorValues.None))]
  None,
  /// <summary>
  ///   Straight Connector.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.ConnectorValues.Straight))]
  Straight,
  /// <summary>
  ///   Elbow Connector.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.ConnectorValues.Elbow))]
  Elbow,
  /// <summary>
  ///   Curved Connector.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.ConnectorValues.Curved))]
  Curved
}