namespace DocumentModel.Drawings;
/// <summary>
///   Defines the ClassificationOutcomeType enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2019.Presentation.ClassificationOutcomeType))]
public enum ClassificationOutcomeType
{
  /// <summary>
  ///   none.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2019.Presentation.ClassificationOutcomeType.None))]
  None,
  /// <summary>
  ///   hdr.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2019.Presentation.ClassificationOutcomeType.Hdr))]
  Hdr,
  /// <summary>
  ///   ftr.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2019.Presentation.ClassificationOutcomeType.Ftr))]
  Ftr,
  /// <summary>
  ///   watermark.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2019.Presentation.ClassificationOutcomeType.Watermark))]
  Watermark
}