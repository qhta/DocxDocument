namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word resizes a table when the AutoFit feature is used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdautofitbehavior?view=office-pia` for Office interop details.
/// </remarks>
public enum WdAutoFitBehavior
{
  /// <summary>
  /// Specifies how Microsoft Word resizes a table when the AutoFit feature is used.
  /// </summary>
  Fixed = 0,
  /// <summary>
  /// Specifies how Microsoft Word resizes a table when the AutoFit feature is used.
  /// </summary>
  Content = 1,
  /// <summary>
  /// Specifies how Microsoft Word resizes a table when the AutoFit feature is used.
  /// </summary>
  Window = 2
}
