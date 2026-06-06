namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the appearance of delimiters (parentheses, braces, brackets) in relationship to the content that
/// they surround.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathshapetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdOMathShapeType")]
public enum MathShapeType
{
  /// <summary>
  /// Vertically centers delimiters around the entire height of the equation causing delimiters grow equally above
  /// and below their midpoint.
  /// </summary>
  [InteropEnumValue("wdOMathShapeCentered")]
  Centered = 0,
  /// <summary>
  /// Matches the shape of the delimiters to the size of their contents.
  /// </summary>
  [InteropEnumValue("wdOMathShapeMatch")]
  Match = 1
}
