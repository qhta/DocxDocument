namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the appearance of delimiters (parentheses, braces, brackets) in relationship to the content that
/// they surround.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathshapetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdOMathShapeType")]
public enum OMathShapeType
{
  /// <summary>
  /// Vertically centers delimiters around the entire height of the equation causing delimiters grow equally above
  /// and below their midpoint.
  /// </summary>
  [WordInteropEnumValue("wdOMathShapeCentered")]
  Centered = 0,
  /// <summary>
  /// Matches the shape of the delimiters to the size of their contents.
  /// </summary>
  [WordInteropEnumValue("wdOMathShapeMatch")]
  Match = 1
}
