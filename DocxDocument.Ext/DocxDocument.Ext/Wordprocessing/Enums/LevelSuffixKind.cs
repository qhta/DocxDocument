namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LevelSuffixValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum LevelSuffixKind
{
  /// <summary>
  ///   Tab Between Numbering and Text.
  /// </summary>
  Tab,

  /// <summary>
  ///   Space Between Numbering and Text.
  /// </summary>
  Space,

  /// <summary>
  ///   Nothing Between Numbering and Text.
  /// </summary>
  Nothing
}