
namespace DocumentModel.Application;

/// <summary>
/// Represents a policy specified for a server-stored document type.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy?view=office-pia"/>
public partial interface ServerPolicy: IModelCollection<PolicyItem>
{
  /// <summary>
  /// Gets the server policy ID.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.id?view=office-pia"/>
  public string Id { get; }
  /// <summary>
  /// Gets the policy name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the policy description.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.description?view=office-pia"/>
  public string Description { get; }
  /// <summary>
  /// Gets the policy statement.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.statement?view=office-pia"/>
  public string Statement { get; }
  /// <summary>
  /// Gets the number of policy items.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.count?view=office-pia"/>
  public int Count { get; }
  /// <summary>
  /// Gets a value that indicates whether preview is blocked by policy.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.blockpreview?view=office-pia"/>
  public bool BlockPreview { get; }
}

