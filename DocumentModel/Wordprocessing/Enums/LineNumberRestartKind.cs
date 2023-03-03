namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the LineNumberRestartValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LineNumberRestartKind
{
  /// <summary>
  ///   Restart Line Numbering on Each Page.
  /// </summary>
  NewPage,

  /// <summary>
  ///   Restart Line Numbering for Each Section.
  /// </summary>
  NewSection,

  /// <summary>
  ///   Continue Line Numbering From Previous Section.
  /// </summary>
  Continuous
}