namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Font Alignment Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextFontAlignmentKind
{
  /// <summary>
  ///   Font Alignment Enum ( Automatic ).
  /// </summary>
  Automatic,

  /// <summary>
  ///   Font Alignment Enum ( Top ).
  /// </summary>
  Top,

  /// <summary>
  ///   Font Alignment Enum ( Center ).
  /// </summary>
  Center,

  /// <summary>
  ///   Font Alignment Enum ( Baseline ).
  /// </summary>
  Baseline,

  /// <summary>
  ///   Font Alignment Enum ( Bottom ).
  /// </summary>
  Bottom
}