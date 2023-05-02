namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Tick Mark
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TickMarkKind
{
  /// <summary>
  ///   Cross.
  /// </summary>
  Cross,

  /// <summary>
  ///   Inside.
  /// </summary>
  Inside,

  /// <summary>
  ///   None.
  /// </summary>
  None,

  /// <summary>
  ///   Outside.
  /// </summary>
  Outside
}