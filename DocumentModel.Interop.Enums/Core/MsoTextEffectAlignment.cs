namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies alignment for WordArt text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotexteffectalignment?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoTextEffectAlignment")]
public enum TextEffectAlignment
{
  /// <summary>
  /// Not used.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectAlignmentMixed")]
  Mixed = -2,
  /// <summary>
  /// Left-aligned.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectAlignmentLeft")]
  Left = 1,
  /// <summary>
  /// Centered.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectAlignmentCentered")]
  Centered = 2,
  /// <summary>
  /// Right- aligned.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectAlignmentRight")]
  Right = 3,
  /// <summary>
  /// Text is justified. Spacing between letters may be adjusted to justify text.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectAlignmentLetterJustify")]
  LetterJustify = 4,
  /// <summary>
  /// Text is justified. Spacing between words (but not letters) may be adjusted to justify text.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectAlignmentWordJustify")]
  WordJustify = 5,
  /// <summary>
  /// Text is justified. Letters may be stretched to justify text.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectAlignmentStretchJustify")]
  StretchJustify = 6
}
