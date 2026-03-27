using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents an individual project item branch in the Project Explorer in the Microsoft Script Editor.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem?view=office-pia"/>
public partial interface HTMLProjectItem: InteropObject
{
  /// <summary>
  /// Updates the text in the Microsoft Script Editor with text from the specified file on disk.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem.loadfromfile?view=office-pia"/>
  public void LoadFromFile(string FileName);
  /// <summary>
  /// Opens the specified HTML project item in the Microsoft Script Editor in one of the supported views.
  /// </summary>
  /// <param name="OpenKind">The `OpenKind` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem.open?view=office-pia"/>
  public void Open(HTMLProjectOpen OpenKind);
  /// <summary>
  /// Saves the specified HTML project item using a new file name.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem.savecopyas?view=office-pia"/>
  public void SaveCopyAs(string FileName);
}

