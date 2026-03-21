using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a Document Inspector module in a DocumentInspectors collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector?view=office-pia"/>
public partial interface DocumentInspector: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector.description?view=office-pia"/>
  public string Description { get; }
}

