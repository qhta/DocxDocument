using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `SharedWorkspaceLink` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceLink: InteropObject
{
  /// <summary>
  /// Gets or sets the `URL` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.url?view=office-pia"/>
  public string URL { get; set; }
  /// <summary>
  /// Gets or sets the `Description` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.description?view=office-pia"/>
  public string Description { get; set; }
  /// <summary>
  /// Gets or sets the `Notes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.notes?view=office-pia"/>
  public string Notes { get; set; }
  /// <summary>
  /// Gets the `CreatedBy` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.createdby?view=office-pia"/>
  public string CreatedBy { get; }
  /// <summary>
  /// Gets the `CreatedDate` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.createddate?view=office-pia"/>
  public object CreatedDate { get; }
  /// <summary>
  /// Gets the `ModifiedBy` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.modifiedby?view=office-pia"/>
  public string ModifiedBy { get; }
  /// <summary>
  /// Gets the `ModifiedDate` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.modifieddate?view=office-pia"/>
  public object ModifiedDate { get; }
}

