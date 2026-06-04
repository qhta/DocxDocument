
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the view in which an HTML project or project item is opened.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msohtmlprojectopen?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoHTMLProjectOpen")]
public enum HTMLProjectOpen
{
  /// <summary>
  /// Open project in source view.
  /// </summary>
  [InteropEnumValue("msoHTMLProjectOpenSourceView")]
  SourceView = 1,
  /// <summary>
  /// Open project in text view.
  /// </summary>
  [InteropEnumValue("msoHTMLProjectOpenTextView")]
  TextView
}
