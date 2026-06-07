namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of window.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdwindowtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdWindowType")]
public enum WindowType
{
  /// <summary>
  /// A document window.
  /// </summary>
  [InteropEnumValue("wdWindowDocument")]
  Document = 0,
  /// <summary>
  /// A template window.
  /// </summary>
  [InteropEnumValue("wdWindowTemplate")]
  Template = 1
}
