namespace DocumentModel.Vml;
/// <summary>
///   OLE Object Representations
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.OleDrawAspectValues))]
public enum OleDrawAspectKind
{
  /// <summary>
  ///   Snapshot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.OleDrawAspectValues.Content))]
  Content,
  /// <summary>
  ///   Icon.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.OleDrawAspectValues.Icon))]
  Icon
}