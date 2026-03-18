namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TabAlignment enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum TabAlignment
{
  /// <summary>Left-aligned tab</summary>
  [OpenXmlEnumValue("Left")]
  Left = 0,
  /// <summary>Center-aligned tab</summary>
  [OpenXmlEnumValue("Center")]
  Center = 1,
  /// <summary>Right-aligned tab</summary>
  [OpenXmlEnumValue("Right")]
  Right = 2,
  /// <summary>Decimal-aligned tab</summary>
  [OpenXmlEnumValue("Decimal")]
  Decimal = 3,
  /// <summary>Bar tab (vertical line)</summary>
  [OpenXmlEnumValue("Bar")]
  Bar = 4
}
