using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a file in a shared workspace.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile?view=office-pia"/>
public partial interface ISharedWorkspaceFile: IInteropObject
{
  /// <summary>
  /// Gets the `URL` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile.url?view=office-pia"/>
  public string URL { get; }
  /// <summary>
  /// Gets the `CreatedBy` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile.createdby?view=office-pia"/>
  public string CreatedBy { get; }
  /// <summary>
  /// Gets the `CreatedDate` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile.createddate?view=office-pia"/>
  public object CreatedDate { get; }
  /// <summary>
  /// Gets the `ModifiedBy` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile.modifiedby?view=office-pia"/>
  public string ModifiedBy { get; }
  /// <summary>
  /// Gets the `ModifiedDate` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile.modifieddate?view=office-pia"/>
  public object ModifiedDate { get; }


  #region methods

/// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile.delete?view=office-pia"/>
  public void Delete();

  #endregion methods
}

