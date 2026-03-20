using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PolicyItem` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PolicyItem: InteropObject
{
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem.id?view=office-pia
  /// </remarks>
  public string Id { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem.description?view=office-pia
  /// </remarks>
  public string Description { get; }
  /// <summary>
  /// Gets the `Data` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem.data?view=office-pia
  /// </remarks>
  public string Data { get; }
}
