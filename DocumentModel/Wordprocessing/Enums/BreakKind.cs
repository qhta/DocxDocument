namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the BreakValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BreakKind
{
  /// <summary>
  ///   IPage IBreak.
  /// </summary>
  IPage,

  /// <summary>
  ///   IColumn IBreak.
  /// </summary>
  IColumn,

  /// <summary>
  ///   ILine IBreak.
  /// </summary>
  TextWrapping
}
