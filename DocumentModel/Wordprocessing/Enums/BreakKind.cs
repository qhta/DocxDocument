namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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