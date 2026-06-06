namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the vertical alignment of equations within the shape canvas or the line, for inline equations.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathvertaligntype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdOMathVertAlignType")]
public enum MathVertAlignType
{
  /// <summary>
  /// Vertically centers the equation in the shape canvas or line.
  /// </summary>
  [InteropEnumValue("wdOMathVertAlignCenter")]
  Center = 0,
  /// <summary>
  /// Aligns the equation on the top of the shape canvas or line.
  /// </summary>
  [InteropEnumValue("wdOMathVertAlignTop")]
  Top = 1,
  /// <summary>
  /// Aligns the equation on the bottom of the shape canvas or line.
  /// </summary>
  [InteropEnumValue("wdOMathVertAlignBottom")]
  Bottom = 2
}
