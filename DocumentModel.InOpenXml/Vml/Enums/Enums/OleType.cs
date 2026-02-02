namespace DocumentModel.Vml;
/// <summary>
///   OLE Connection Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.OleValues))]
public enum OleType
{
  /// <summary>
  ///   Embedded Object.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.OleValues.Embed))]
  Embed,
  /// <summary>
  ///   Linked Object.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.OleValues.Link))]
  Link
}