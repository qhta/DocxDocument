namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of window.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdwindowtype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdWindowType
{
  /// <summary>
  /// A document window.
  /// </summary>
  Document = 0,
  /// <summary>
  /// A template window.
  /// </summary>
  Template = 1
}
