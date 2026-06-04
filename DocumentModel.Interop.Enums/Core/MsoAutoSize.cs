namespace DocumentModel.Interop.Core;

/// <summary>
/// Determines the type of automatic sizing allowed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoautosize?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoAutoSize))]
public enum AutoSize
{
  /// <summary>
  /// A combination of automatic sizing schemes are used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoSize.msoAutoSizeMixed))]
  Mixed = -2,
  /// <summary>
  /// No autosizing.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoSize.msoAutoSizeNone))]
  None = 0,
  /// <summary>
  /// The shape is adjusted to fit the text.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoSize.msoAutoSizeShapeToFitText))]
  ShapeToFitText = 1,
  /// <summary>
  /// The text is adjusted to fit the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoSize.msoAutoSizeTextToFitShape))]
  TextToFitShape = 2
}
