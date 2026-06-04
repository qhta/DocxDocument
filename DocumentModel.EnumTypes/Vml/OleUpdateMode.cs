namespace DocumentModel.Vml;
/// <summary>
///   OLE Update Method Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues))]
public enum OleUpdateMode
{
  /// <summary>
  ///   Server Application Update.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues.Always))]
  Always,
  /// <summary>
  ///   User Update.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues.OnCall))]
  OnCall
}