using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a Document Inspector module in a DocumentInspectors collection.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector?view=office-pia
/// </remarks>
public partial interface DocumentInspector: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector.description?view=office-pia
  /// </remarks>
  public string Description { get; }
}
