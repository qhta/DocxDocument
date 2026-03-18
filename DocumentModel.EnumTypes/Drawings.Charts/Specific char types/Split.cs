namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Split enumeration.
/// Used in types such as DocumentCleaner, DocumentCleaner.GraphicTools, DocumentCleaner.TableTools.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.SplitValues))]
public enum Split
{
  /// <summary>
  ///   Custom Split.
  /// </summary>
  [OpenXmlEnumValue("Custom")]
  Custom,
  /// <summary>
  ///   Split by Percentage.
  /// </summary>
  [OpenXmlEnumValue("Percent")]
  Percent,
  /// <summary>
  ///   Split by Position.
  /// </summary>
  [OpenXmlEnumValue("Position")]
  Position,
  /// <summary>
  ///   Split by Value.
  /// </summary>
  [OpenXmlEnumValue("Value")]
  Value
}
