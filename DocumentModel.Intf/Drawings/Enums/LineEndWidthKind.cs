namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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