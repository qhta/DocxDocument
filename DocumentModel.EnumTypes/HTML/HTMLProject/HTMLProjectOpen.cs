
namespace DocumentModel.HTML;

/// <summary>
/// Specifies the view Iin which an HTML project or project item is opened.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msohtmlprojectopen?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum HTMLProjectOpen
{
  /// <summary>
  /// Open project Iin source view.
  /// </summary>
  SourceView = 1,
  /// <summary>
  /// Open project Iin text view.
  /// </summary>
  TextView
}

