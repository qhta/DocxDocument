namespace DocumentModel.Drawings;
/// <summary>
///   Defines the ClassificationOutcomeType enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO19P.ClassificationOutcomeType))]
public enum ClassificationOutcomeType
{
  /// <summary>
  ///   none.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO19P.ClassificationOutcomeType.None))]
  None,
  /// <summary>
  ///   hdr.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO19P.ClassificationOutcomeType.Hdr))]
  Hdr,
  /// <summary>
  ///   ftr.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO19P.ClassificationOutcomeType.Ftr))]
  Ftr,
  /// <summary>
  ///   watermark.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO19P.ClassificationOutcomeType.Watermark))]
  Watermark
}