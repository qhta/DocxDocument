namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of vertical alignment to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdverticalalignment?view=office-pia` for Office interop details.
/// </remarks>
public enum WdVerticalAlignment
{
  /// <summary>
  /// Top vertical alignment.
  /// </summary>
  Top = 0,
  /// <summary>
  /// Center vertical alignment.
  /// </summary>
  Center = 1,
  /// <summary>
  /// Justified vertical alignment.
  /// </summary>
  Justify = 2,
  /// <summary>
  /// Bottom vertical alignment.
  /// </summary>
  Bottom = 3
}
