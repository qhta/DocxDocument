using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a block of HTML script in an Office document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script?view=office-pia"/>
public partial class Script
{
  /// <summary>
  /// Deletes this script from the collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }
}

