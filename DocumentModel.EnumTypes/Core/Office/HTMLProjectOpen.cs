
namespace DocumentMode.Office;

/// <summary>
/// Specifies the view in which an HTML project or project item is opened.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msohtmlprojectopen?view=office-pia` for Office interop details.
/// </remarks>
public enum HTMLProjectOpen
{
  /// <summary>
  /// Open project in source view.
  /// </summary>
  SourceView = 1,
  /// <summary>
  /// Open project in text view.
  /// </summary>
  TextView
}
