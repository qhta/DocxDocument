namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ClassificationOutcomeType enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ClassificationOutcomeType
{
  /// <summary>
  ///   none.
  /// </summary>
  None,
  /// <summary>
  ///   hdr.
  /// </summary>
  Hdr,
  /// <summary>
  ///   ftr.
  /// </summary>
  Ftr,
  /// <summary>
  ///   watermark.
  /// </summary>
  Watermark
}