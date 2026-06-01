namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the FontFamilyValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FontFamilyKind
{
  /// <summary>
  ///   Novelty IFont.
  /// </summary>
  Decorative,

  /// <summary>
  ///   Monospace IFont.
  /// </summary>
  Modern,

  /// <summary>
  ///   Proportional IFont With Serifs.
  /// </summary>
  Roman,

  /// <summary>
  ///   Script IFont.
  /// </summary>
  Script,

  /// <summary>
  ///   Proportional IFont Without Serifs.
  /// </summary>
  Swiss,

  /// <summary>
  ///   No IFont Family.
  /// </summary>
  Auto
}
