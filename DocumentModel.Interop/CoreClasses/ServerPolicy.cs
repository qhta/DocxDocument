
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a policy specified for a server-stored document type.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy?view=office-pia"/>
public partial class ServerPolicy: InteropCollection<PolicyItem>
{
  /// <summary>
  /// Gets the server policy ID.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.id?view=office-pia"/>
  public string Id { get; set; } = string.Empty;
  /// <summary>
  /// Gets the policy name.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.name?view=office-pia"/>
  public string Name { get; set;} = string.Empty;
  /// <summary>
  /// Gets the policy description.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.description?view=office-pia"/>
  public string Description { get; set; } = string.Empty;
  /// <summary>
  /// Gets the policy statement.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.statement?view=office-pia"/>
  public string Statement { get; set; } = string.Empty;
  /// <summary>
  /// Gets a value that indicates whether preview is blocked by policy.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.serverpolicy.blockpreview?view=office-pia"/>
  public bool BlockPreview { get; set; }
}

