namespace DocumentModel.Vml;
/// <summary>
///   OLE Connection Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.OleValues))]
public enum OleType
{
  /// <summary>
  ///   Embedded Object.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.OleValues.Embed))]
  Embed,
  /// <summary>
  ///   Linked Object.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.OleValues.Link))]
  Link
}