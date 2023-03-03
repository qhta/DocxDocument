namespace DocumentModel.Drawings;

/// <summary>
///   Vertical Text Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextVerticalKind
{
  /// <summary>
  ///   Vertical Text Type Enum ( Horizontal ).
  /// </summary>
  Horizontal,

  /// <summary>
  ///   Vertical Text Type Enum ( Vertical ).
  /// </summary>
  Vertical,

  /// <summary>
  ///   Vertical Text Type Enum ( Vertical 270 ).
  /// </summary>
  Vertical270,

  /// <summary>
  ///   Vertical Text Type Enum ( WordArt Vertical ).
  /// </summary>
  WordArtVertical,

  /// <summary>
  ///   Vertical Text Type Enum ( East Asian Vertical ).
  /// </summary>
  EastAsianVetical,

  /// <summary>
  ///   Vertical Text Type Enum ( Mongolian Vertical ).
  /// </summary>
  MongolianVertical,

  /// <summary>
  ///   Vertical WordArt Right to Left.
  /// </summary>
  WordArtLeftToRight
}