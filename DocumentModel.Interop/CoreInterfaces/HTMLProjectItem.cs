using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents an individual project item branch in the Project Explorer in the Microsoft Script Editor.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem?view=office-pia
/// </remarks>
public partial interface HTMLProjectItem: InteropObject
{
  /// <summary>
  /// Gets the name of the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Determines whether the specified HTML project item is open in the Microsoft Script Editor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem.isopen?view=office-pia
  /// </remarks>
  public bool IsOpen { get; }
  /// <summary>
  /// Gets or sets the HTML text in the HTML editor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem.text?view=office-pia
  /// </remarks>
  public string Text { get; set; }
}
