
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a policy specified for a server-stored document type.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy?view=office-pia
/// </remarks>
public partial interface ServerPolicy: InteropObject
{
  /// <summary>
  /// Gets a policy item by name or index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.item?view=office-pia
  /// </remarks>
  public PolicyItem this[object Index] { get; }
  /// <summary>
  /// Gets the server policy ID.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.id?view=office-pia
  /// </remarks>
  public string Id { get; }
  /// <summary>
  /// Gets the policy name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the policy description.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.description?view=office-pia
  /// </remarks>
  public string Description { get; }
  /// <summary>
  /// Gets the policy statement.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.statement?view=office-pia
  /// </remarks>
  public string Statement { get; }
  /// <summary>
  /// Gets the number of policy items.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.count?view=office-pia
  /// </remarks>
  public int Count { get; }
  /// <summary>
  /// Gets a value that indicates whether preview is blocked by policy.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.blockpreview?view=office-pia
  /// </remarks>
  public bool BlockPreview { get; }
}
