using System.Reflection;

namespace DocumentModel.HTML;

/// <summary>
/// Represents an individual project item branch in the Project Explorer in the Microsoft Script Editor.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem?view=office-pia"/>
public partial interface HTMLProjectItem: InteropObject
{
  /// <summary>
  /// Gets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Determines whether the specified HTML project item is open in the Microsoft Script Editor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem.isopen?view=office-pia"/>
  public bool IsOpen { get; }
  /// <summary>
  /// Gets or sets the HTML text in the HTML editor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem.text?view=office-pia"/>
  public string Text { get; set; }
}

