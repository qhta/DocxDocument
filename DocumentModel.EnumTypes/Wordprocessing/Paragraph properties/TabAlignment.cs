namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TabAlignment enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TabAlignment
{
  /// <summary>Left-aligned tab</summary>
  [OpenXmlEnumValue("Left")]
  Left = 0,
  /// <summary>Center-aligned tab</summary>
  [OpenXmlEnumValue("Center")]
  Center,
  /// <summary>Right-aligned tab</summary>
  [OpenXmlEnumValue("Right")]
  Right,
  /// <summary>Decimal-aligned tab</summary>
  [OpenXmlEnumValue("Decimal")]
  Decimal,
  /// <summary>Bar tab (vertical line)</summary>
  [OpenXmlEnumValue("Bar")]
  Bar,
  /// <summary>
  /// List aligned.
  /// </summary>
  [OpenXmlEnumValue("List")]
  List = 6,
}
