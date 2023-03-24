namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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