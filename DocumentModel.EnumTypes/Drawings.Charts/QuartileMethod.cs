namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the QuartileMethod enumeration.
/// Used in types such as Statistics, QuartileMethod, StatisticsConverter.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
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

