namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies alignment for WordArt text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotexteffectalignment?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoTextEffectAlignment))]
public enum TextEffectAlignment
{
  /// <summary>
  /// Not used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentMixed))]
  Mixed = -2,
  /// <summary>
  /// Left-aligned.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft))]
  Left = 1,
  /// <summary>
  /// Centered.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentCentered))]
  Centered = 2,
  /// <summary>
  /// Right- aligned.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentRight))]
  Right = 3,
  /// <summary>
  /// Text is justified. Spacing between letters may be adjusted to justify text.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLetterJustify))]
  LetterJustify = 4,
  /// <summary>
  /// Text is justified. Spacing between words (but not letters) may be adjusted to justify text.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentWordJustify))]
  WordJustify = 5,
  /// <summary>
  /// Text is justified. Letters may be stretched to justify text.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentStretchJustify))]
  StretchJustify = 6
}
