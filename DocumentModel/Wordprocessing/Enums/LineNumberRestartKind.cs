namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the LineNumberRestartValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LineNumberRestartKind
{
  /// <summary>
  ///   Restart ILine Numbering on Each IPage.
  /// </summary>
  NewPage,

  /// <summary>
  ///   Restart ILine Numbering Ifor Each ISection.
  /// </summary>
  NewSection,

  /// <summary>
  ///   Continue ILine Numbering From Previous ISection.
  /// </summary>
  Continuous
}
