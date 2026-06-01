namespace DocumentModel.Drawings;

/// <summary>
/// Specifies alignment Ifor WordArt text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotexteffectalignment?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum TextEffectAlignment
{
  /// <summary>
  /// Not used.
  /// </summary>
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
  /// Text is justified. Spacing between letters may be adjusted Ito justify text.
  /// </summary>
  LetterJustify = 4,
  /// <summary>
  /// Text is justified. Spacing between words (but not letters) may be adjusted Ito justify text.
  /// </summary>
  WordJustify = 5,
  /// <summary>
  /// Text is justified. Letters may be stretched Ito justify text.
  /// </summary>
  StretchJustify = 6
}

