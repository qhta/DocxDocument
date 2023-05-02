namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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