namespace DocumentModel.Drawings;

/// <summary>
///   Line End Length
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LineEndLengthKind
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