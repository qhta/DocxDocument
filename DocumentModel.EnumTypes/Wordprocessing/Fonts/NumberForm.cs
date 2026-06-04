namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the NumberFormValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2010.Word.NumberFormValues))]
public enum NumberForm
{
  /// <summary>
  ///   default.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.NumberFormValues.Default))]
  Default,
  /// <summary>
  ///   lining.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.NumberFormValues.Lining))]
  Lining,
  /// <summary>
  ///   oldStyle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.NumberFormValues.OldStyle))]
  OldStyle
}