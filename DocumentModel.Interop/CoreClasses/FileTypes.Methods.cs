using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of FileType values used by FileSearch.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filetypes?view=office-pia"/>
public partial class FileTypes: InteropCollection<FileType>
{
  /// <summary>
  /// Removes a file type from the collection.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filetypes.remove?view=office-pia"/>
  public void Remove(int Index) { throw new NotImplementedException(); }
}

