namespace DocumentModel.Wordprocessing;
/// <summary>
///   Linked Object Update Modes
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.ObjectUpdateMode))]
public enum ObjectUpdateMode
{
  /// <summary>
  ///   always.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ObjectUpdateMode.always))]
  Always,
  /// <summary>
  ///   onCall.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ObjectUpdateMode.onCall))]
  OnCall
}