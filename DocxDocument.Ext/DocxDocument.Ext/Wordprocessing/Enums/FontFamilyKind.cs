namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FontFamilyValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum FontFamilyKind
{
  /// <summary>
  ///   Novelty Font.
  /// </summary>
  Decorative,

  /// <summary>
  ///   Monospace Font.
  /// </summary>
  Modern,

  /// <summary>
  ///   Proportional Font With Serifs.
  /// </summary>
  Roman,

  /// <summary>
  ///   Script Font.
  /// </summary>
  Script,

  /// <summary>
  ///   Proportional Font Without Serifs.
  /// </summary>
  Swiss,

  /// <summary>
  ///   No Font Family.
  /// </summary>
  Auto
}