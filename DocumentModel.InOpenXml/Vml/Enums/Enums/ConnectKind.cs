namespace DocumentModel.Vml;
/// <summary>
///   Connection Locations Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.ConnectValues))]
public enum ConnectKind
{
  /// <summary>
  ///   No.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ConnectValues.None))]
  None,
  /// <summary>
  ///   Four Connections.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ConnectValues.Rectangle))]
  Rectangle,
  /// <summary>
  ///   Edit Point Connections.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ConnectValues.Segments))]
  Segments,
  /// <summary>
  ///   Custom Connections.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ConnectValues.Custom))]
  Custom
}