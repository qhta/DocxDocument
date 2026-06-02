using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of HTML project items contained in an HTML project.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitems?view=office-pia"/>
public partial interface IHTMLProjectItems: IInteropCollection<HTMLProjectItem>
{


  #region methods

/// <summary>
  /// Returns the HTML project item that represents a particular project in the Microsoft Script Editor.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitems.item?view=office-pia"/>
  public HTMLProjectItem Item(ref object Index);

  #endregion methods
}

