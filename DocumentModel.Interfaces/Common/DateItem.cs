namespace DocumentModel;

/// <summary>
/// Defines the DateItem enumeration.
/// Used in types such as DateItem, RunDate, RunDate(T).
/// </summary>
[Flags]
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlNotMapped]
public enum DateItem
{
  /// <summary>
  ///   Day is presented
  /// </summary>
  [OpenXmlEnumValue("Day")]
  Day = 1,

  /// <summary>
  ///   Month is presented
  /// </summary>
  [OpenXmlEnumValue("Month")]
  Month = 2,

  /// <summary>
  ///   Year is presented
  /// </summary>
  [OpenXmlEnumValue("Year")]
  Year = 4,

  /// <summary>
  ///   Full date is presented
  /// </summary>
  [OpenXmlEnumValue("Full")]
  Full = 7,
}
