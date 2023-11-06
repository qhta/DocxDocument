namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LineNumberRestartValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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