using System.Reflection;	
namespace DocumentModel.Interop.Core;	
/// <summary>
/// Represents the `SharedWorkspaceTask` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask?view=office-pia` for Office interop details.
/// </remarks>
public interface ISharedWorkspaceTask: IInteropObject
{
  /// <summary>
  /// Gets or sets the `Title` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.title?view=office-pia"/>
  public string Title { get; set; }
  /// <summary>
  /// Gets or sets the `AssignedTo` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.assignedto?view=office-pia"/>
  public string AssignedTo { get; set; }
  /// <summary>
  /// Gets or sets the `Status` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.status?view=office-pia"/>
  public SharedWorkspaceTaskStatus Status { get; set; }
  /// <summary>
  /// Gets or sets the `Priority` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.priority?view=office-pia"/>
  public SharedWorkspaceTaskPriority Priority { get; set; }
  /// <summary>
  /// Gets or sets the `Description` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.description?view=office-pia"/>
  public string Description { get; set; }
  /// <summary>
  /// Gets or sets the `DueDate` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.duedate?view=office-pia"/>
  public object DueDate { get; set; }
  /// <summary>
  /// Gets the `CreatedBy` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.createdby?view=office-pia"/>
  public string CreatedBy { get; }
  /// <summary>
  /// Gets the `CreatedDate` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.createddate?view=office-pia"/>
  public object CreatedDate { get; }
  /// <summary>
  /// Gets the `ModifiedBy` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.modifiedby?view=office-pia"/>
  public string ModifiedBy { get; }
  /// <summary>
  /// Gets the `ModifiedDate` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.modifieddate?view=office-pia"/>
  public object ModifiedDate { get; }	

  #region methods	
/// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.save?view=office-pia"/>
  public void Save();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.delete?view=office-pia"/>
  public void Delete();	
  #endregion methods
}	
