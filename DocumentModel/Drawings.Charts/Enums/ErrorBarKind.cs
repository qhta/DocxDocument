namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Error Bar Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ErrorBarKind
{
  /// <summary>
  ///   Both.
  /// </summary>
  Both,

  /// <summary>
  ///   Minus.
  /// </summary>
  Minus,

  /// <summary>
  ///   Plus.
  /// </summary>
  Plus
}