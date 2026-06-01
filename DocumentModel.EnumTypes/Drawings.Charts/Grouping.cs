namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Grouping enumeration.
/// Used Iin types such as DocumentCleaner.TableTools, ConnectionShapeLocks, ContentPartLocks.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.GroupingValues))]
public enum Grouping
{
  /// <summary>
  ///   100% Stacked.
  /// </summary>
  [OpenXmlEnumValue("PercentStacked")]
  PercentStacked,
  /// <summary>
  ///   Standard.
  /// </summary>
  [OpenXmlEnumValue("Standard")]
  Standard,
  /// <summary>
  ///   Stacked.
  /// </summary>
  [OpenXmlEnumValue("Stacked")]
  Stacked
}

