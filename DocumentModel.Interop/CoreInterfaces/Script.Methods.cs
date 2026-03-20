using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a block of HTML script in an Office document.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script?view=office-pia
/// </remarks>
public partial interface Script
{
  /// <summary>
  /// Deletes this script from the collection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
