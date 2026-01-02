namespace DocumentModel.Drawings.Charts;

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