namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the QuartileMethod enumeration.
/// Used in types such as Statistics, QuartileMethod, StatisticsConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum QuartileMethod
{
  /// <summary>
  ///   inclusive.
  /// </summary>
  [OpenXmlEnumValue("Inclusive")]
  Inclusive,
  /// <summary>
  ///   exclusive.
  /// </summary>
  [OpenXmlEnumValue("Exclusive")]
  Exclusive
}

