using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents a single policy setting within a server policy.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem?view=office-pia"/>
public partial interface IPolicyItem: IModelObject
{
  /// <summary>
  /// Gets the ID of the policy item.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem.id?view=office-pia"/>
  public string Id { get; }
  /// <summary>
  /// Gets the display name of the policy item.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the description of the policy item.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem.description?view=office-pia"/>
  public string Description { get; }
  /// <summary>
  /// Gets the policy data for the item.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.policyitem.data?view=office-pia"/>
  public string Data { get; }
}

