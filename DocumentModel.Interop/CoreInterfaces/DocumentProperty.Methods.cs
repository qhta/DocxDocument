using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a custom or built-in document property.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty?view=office-pia
/// </remarks>
public partial interface DocumentProperty
{
  /// <summary>
  /// Deletes the document property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
