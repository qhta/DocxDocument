namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ListApplyDefaultBehavior enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum ListApplyDefaultBehavior
{
  /// <summary>Apply Word 2002 and earlier behavior</summary>
  [OpenXmlEnumValue("Word2002Behavior")]
  Word2002Behavior = 0,
  /// <summary>Apply Word 2003 and later behavior</summary>
  [OpenXmlEnumValue("Word2003Behavior")]
  Word2003Behavior = 1
}
