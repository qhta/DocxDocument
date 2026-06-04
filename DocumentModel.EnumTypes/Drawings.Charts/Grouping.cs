namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Grouping enumeration.
/// Used in types such as DocumentCleaner.TableTools, ConnectionShapeLocks, ContentPartLocks.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.GroupingValues))]
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

