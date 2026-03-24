namespace DocumentModel.Interop.Core;

/// <summary>
/// Determines the type of automatic sizing allowed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoautosize?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoAutoSize
{
  /// <summary>
  /// A combination of automatic sizing schemes are used.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// No autosizing.
  /// </summary>
  None = 0,
  /// <summary>
  /// The shape is adjusted to fit the text.
  /// </summary>
  ShapeToFitText = 1,
  /// <summary>
  /// The text is adjusted to fit the shape.
  /// </summary>
  TextToFitShape = 2
}
