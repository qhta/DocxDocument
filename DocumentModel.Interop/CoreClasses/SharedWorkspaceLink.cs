using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceLink` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink?view=office-pia` for Office interop details.
/// </remarks>
public partial class SharedWorkspaceLink: InteropObject
{
  /// <summary>
  /// Gets or sets the `URL` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.url?view=office-pia"/>
  public string URL { get; set; }
  /// <summary>
  /// Gets or sets the `Description` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.description?view=office-pia"/>
  public string Description { get; set; }
  /// <summary>
  /// Gets or sets the `Notes` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.notes?view=office-pia"/>
  public string Notes { get; set; }
  /// <summary>
  /// Gets the `CreatedBy` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.createdby?view=office-pia"/>
  public string CreatedBy { get; }
  /// <summary>
  /// Gets the `CreatedDate` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.createddate?view=office-pia"/>
  public object CreatedDate { get; }
  /// <summary>
  /// Gets the `ModifiedBy` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.modifiedby?view=office-pia"/>
  public string ModifiedBy { get; }
  /// <summary>
  /// Gets the `ModifiedDate` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.modifieddate?view=office-pia"/>
  public object ModifiedDate { get; }


  #region methods

/// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.save?view=office-pia"/>
  public void Save() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }

  #endregion methods
}

