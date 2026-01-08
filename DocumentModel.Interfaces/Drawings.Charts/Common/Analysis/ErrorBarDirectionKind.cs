namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Error Bar Direction
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ErrorBarDirectionKind
{
  /// <summary>
  ///   X.
  /// </summary>
  X,
  /// <summary>
  ///   Y.
  /// </summary>
  Y
}