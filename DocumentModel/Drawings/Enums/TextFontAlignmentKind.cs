namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IFont Alignment Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextFontAlignmentKind
{
  /// <summary>
  ///   IFont Alignment Enum ( Automatic ).
  /// </summary>
  Automatic,

  /// <summary>
  ///   IFont Alignment Enum ( Top ).
  /// </summary>
  Top,

  /// <summary>
  ///   IFont Alignment Enum ( Center ).
  /// </summary>
  Center,

  /// <summary>
  ///   IFont Alignment Enum ( Baseline ).
  /// </summary>
  Baseline,

  /// <summary>
  ///   IFont Alignment Enum ( Bottom ).
  /// </summary>
  Bottom
}
