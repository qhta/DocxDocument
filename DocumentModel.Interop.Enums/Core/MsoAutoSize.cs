namespace DocumentModel.Interop.Core;

/// <summary>
/// Determines the type of automatic sizing allowed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoautosize?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoAutoSize")]
public enum AutoSize
{
  /// <summary>
  /// A combination of automatic sizing schemes are used.
  /// </summary>
  [OfficeInteropEnumValue("msoAutoSizeMixed")]
  Mixed = -2,
  /// <summary>
  /// No autosizing.
  /// </summary>
  [OfficeInteropEnumValue("msoAutoSizeNone")]
  None = 0,
  /// <summary>
  /// The shape is adjusted to fit the text.
  /// </summary>
  [OfficeInteropEnumValue("msoAutoSizeShapeToFitText")]
  ShapeToFitText = 1,
  /// <summary>
  /// The text is adjusted to fit the shape.
  /// </summary>
  [OfficeInteropEnumValue("msoAutoSizeTextToFitShape")]
  TextToFitShape = 2
}
