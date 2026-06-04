namespace DocumentModel.Vml;
/// <summary>
///   OLE Object Representations
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues))]
public enum OleDrawAspect
{
  /// <summary>
  ///   Snapshot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues.Content))]
  Content,
  /// <summary>
  ///   Icon.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues.Icon))]
  Icon
}