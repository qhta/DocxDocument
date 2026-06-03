namespace DocumentModel.Drawings;

/// <summary>
/// Determines the type of automatic sizing allowed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoautosize?view=office-pia` for Office interop details.
/// </remarks>
public enum AutoSize
{
  /// <summary>
  /// A combination of automatic sizing schemes are used.
  /// </summary>
  /// <summary>
  /// No autosizing.
  /// </summary>
  None = 0,
  /// <summary>
  /// The shape is adjusted Ito fit the text.
  /// </summary>
  ShapeToFitText = 1,
  /// <summary>
  /// The text is adjusted Ito fit the shape.
  /// </summary>
  TextToFitShape = 2
}

