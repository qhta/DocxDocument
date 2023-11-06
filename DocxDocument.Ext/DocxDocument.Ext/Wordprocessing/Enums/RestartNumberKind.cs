namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the RestartNumberValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum RestartNumberKind
{
  /// <summary>
  ///   Continue Numbering From Previous Section.
  /// </summary>
  Continuous,

  /// <summary>
  ///   Restart Numbering For Each Section.
  /// </summary>
  EachSection,

  /// <summary>
  ///   Restart Numbering On Each Page.
  /// </summary>
  EachPage
}