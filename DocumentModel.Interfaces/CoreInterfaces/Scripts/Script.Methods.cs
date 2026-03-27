using System.Reflection;

namespace DocumentModel.HTML;

/// <summary>
/// Represents a block of HTML script in an Office document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script?view=office-pia"/>
public partial interface Script: InteropObject
{
  /// <summary>
  /// Deletes this script from the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.delete?view=office-pia"/>
  public void Delete();
}

