namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the BreakValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BreakKind
{
  /// <summary>
  ///   Page Break.
  /// </summary>
  Page,

  /// <summary>
  ///   Column Break.
  /// </summary>
  Column,

  /// <summary>
  ///   Line Break.
  /// </summary>
  TextWrapping
}