namespace DocumentModel.Vml;
/// <summary>
///   OLE Update Method Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.OleUpdateModeValues))]
public enum OleUpdateMode
{
  /// <summary>
  ///   Server Application Update.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.OleUpdateModeValues.Always))]
  Always,
  /// <summary>
  ///   User Update.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.OleUpdateModeValues.OnCall))]
  OnCall
}