using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a custom or built-in document property.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty?view=office-pia"/>
public partial interface IDocumentProperty
{
  /// <summary>
  /// Deletes the document property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty.delete?view=office-pia"/>
  public void Delete();
}

