namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CollapseDirection enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum CollapseDirection
{
  /// <summary>Collapse to start</summary>
  [OpenXmlEnumValue("Start")]
  Start,
  /// <summary>Collapse to end</summary>
  [OpenXmlEnumValue("End")]
  End
}
