namespace DocumentModel.Drawings;

/// <summary>
///   Line End Width
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LineEndWidthKind
{
  /// <summary>
  ///   Small.
  /// </summary>
  Small,
  /// <summary>
  ///   Medium.
  /// </summary>
  Medium,
  /// <summary>
  ///   Large.
  /// </summary>
  Large
}