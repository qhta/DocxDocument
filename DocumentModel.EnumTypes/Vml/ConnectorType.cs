namespace DocumentModel.Vml;
/// <summary>
///   Connector Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.ConnectorValues))]
public enum ConnectorType
{
  /// <summary>
  ///   No Connector.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ConnectorValues.None))]
  None,
  /// <summary>
  ///   Straight Connector.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ConnectorValues.Straight))]
  Straight,
  /// <summary>
  ///   Elbow Connector.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ConnectorValues.Elbow))]
  Elbow,
  /// <summary>
  ///   Curved Connector.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ConnectorValues.Curved))]
  Curved
}