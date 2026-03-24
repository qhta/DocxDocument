namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the vertical alignment of equations within the shape canvas or the line, for inline equations.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathvertaligntype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdOMathVertAlignType
{
  /// <summary>
  /// Specifies the vertical alignment of equations within the shape canvas or the line, for inline equations.
  /// </summary>
  Center = 0,
  /// <summary>
  /// Specifies the vertical alignment of equations within the shape canvas or the line, for inline equations.
  /// </summary>
  Top = 1,
  /// <summary>
  /// Specifies the vertical alignment of equations within the shape canvas or the line, for inline equations.
  /// </summary>
  Bottom = 2
}
