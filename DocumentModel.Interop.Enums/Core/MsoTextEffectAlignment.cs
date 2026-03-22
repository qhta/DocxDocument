namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies alignment for WordArt text.
/// </summary>
public enum MsoTextEffectAlignment
{
  /// <summary>
  /// Specifies alignment for WordArt text.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Left-aligned. msoTextEffectAlignmentCentered2 Centered.
  /// </summary>
  Left = 1,
  /// <summary>
  /// Specifies alignment for WordArt text.
  /// </summary>
  Centered = 2,
  /// <summary>
  /// Right- aligned. msoTextEffectAlignmentLetterJustify4 Text is justified. Spacing between letters may be
  /// adjusted to justify text.
  /// </summary>
  Right = 3,
  /// <summary>
  /// Specifies alignment for WordArt text.
  /// </summary>
  LetterJustify = 4,
  /// <summary>
  /// Text is justified. Spacing between words (but not letters) may be adjusted to justify text.
  /// msoTextEffectAlignmentStretchJustify6 Text is justified. Letters may be stretched to justify text.
  /// </summary>
  WordJustify = 5,
  /// <summary>
  /// Specifies alignment for WordArt text.
  /// </summary>
  StretchJustify = 6
}
