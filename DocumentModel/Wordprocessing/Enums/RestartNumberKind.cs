namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the RestartNumberValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RestartNumberKind
{
  /// <summary>
  ///   Continue Numbering From Previous ISection.
  /// </summary>
  Continuous,

  /// <summary>
  ///   Restart Numbering For Each ISection.
  /// </summary>
  EachSection,

  /// <summary>
  ///   Restart Numbering On Each IPage.
  /// </summary>
  EachPage
}
