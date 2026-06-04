namespace DocumentModel.Wordprocessing;
/// <summary>
///   Linked Object Update Modes
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode))]
public enum ObjectUpdateMode
{
  /// <summary>
  ///   always.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode.always))]
  Always,
  /// <summary>
  ///   onCall.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode.onCall))]
  OnCall
}