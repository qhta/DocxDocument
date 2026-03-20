using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single policy setting within a server policy.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem?view=office-pia
/// </remarks>
public partial interface PolicyItem: InteropObject
{
  /// <summary>
  /// Gets the ID of the policy item.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem.id?view=office-pia
  /// </remarks>
  public string Id { get; }
  /// <summary>
  /// Gets the display name of the policy item.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the description of the policy item.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem.description?view=office-pia
  /// </remarks>
  public string Description { get; }
  /// <summary>
  /// Gets the policy data for the item.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem.data?view=office-pia
  /// </remarks>
  public string Data { get; }
}
