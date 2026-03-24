namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the appearance of delimiters (parentheses, braces, brackets) in relationship to the content that
/// they surround.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathshapetype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdOMathShapeType
{
  /// <summary>
  /// Specifies the appearance of delimiters (parentheses, braces, brackets) in relationship to the content that
  /// they surround.
  /// </summary>
  Centered = 0,
  /// <summary>
  /// Specifies the appearance of delimiters (parentheses, braces, brackets) in relationship to the content that
  /// they surround.
  /// </summary>
  Match = 1
}
