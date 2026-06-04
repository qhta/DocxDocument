namespace DocumentModel.Drawings;
/// <summary>
///   Alignment Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.PenAlignmentValues))]
public enum PenAlignment
{
  /// <summary>
  ///   Center Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PenAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Inset Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PenAlignmentValues.Insert))]
  Insert
}