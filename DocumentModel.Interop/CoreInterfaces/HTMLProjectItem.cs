using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents an individual project item branch in the Project Explorer in the Microsoft Script Editor.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem?view=office-pia"/>
public interface IHTMLProjectItem: IInteropObject
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


  #region methods

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

  #endregion methods
}

