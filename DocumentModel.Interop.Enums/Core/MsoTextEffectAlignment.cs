namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies alignment for WordArt text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotexteffectalignment?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoTextEffectAlignment
{
  /// <summary>
  /// Not used.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Left-aligned.
  /// </summary>
  Left = 1,
  /// <summary>
  /// Centered.
  /// </summary>
  Centered = 2,
  /// <summary>
  /// Right- aligned.
  /// </summary>
  Right = 3,
  /// <summary>
  /// Text is justified. Spacing between letters may be adjusted to justify text.
  /// </summary>
  LetterJustify = 4,
  /// <summary>
  /// Text is justified. Spacing between words (but not letters) may be adjusted to justify text.
  /// </summary>
  WordJustify = 5,
  /// <summary>
  /// Text is justified. Letters may be stretched to justify text.
  /// </summary>
  StretchJustify = 6
}
