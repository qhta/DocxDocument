namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   ILine End Length
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
