namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the StylePaneSortMethods enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(string))]
public enum StylePaneSortMethods
{
  /// <summary>
  ///   Default sort.
  /// </summary>
  [OpenXmlEnumValue("default")]
  Default,
  /// <summary>
  ///   Sort by style name.
  /// </summary>
  [OpenXmlEnumValue("name")]
  Name,
  /// <summary>
  ///   Sort by style type.
  /// </summary>
  [OpenXmlEnumValue("type")]
  Type,
  /// <summary>
  ///   Sort by style priority.
  /// </summary>
  [OpenXmlEnumValue("priority")]
  Priority,
  /// <summary>
  ///   Sort by font.
  /// </summary>
  [OpenXmlEnumValue("font")]
  Font,
  /// <summary>
  ///   Sort by base style.
  /// </summary>
  [OpenXmlEnumValue("basedOn")]
  BasedOn,
}