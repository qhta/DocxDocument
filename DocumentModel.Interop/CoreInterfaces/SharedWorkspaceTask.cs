using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceTask` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceTask: InteropObject
{
  /// <summary>
  /// Gets or sets the `Title` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.title?view=office-pia
  /// </remarks>
  public string Title { get; set; }
  /// <summary>
  /// Gets or sets the `AssignedTo` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.assignedto?view=office-pia
  /// </remarks>
  public string AssignedTo { get; set; }
  /// <summary>
  /// Gets or sets the `Status` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.status?view=office-pia
  /// </remarks>
  public MsoSharedWorkspaceTaskStatus Status { get; set; }
  /// <summary>
  /// Gets or sets the `Priority` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.priority?view=office-pia
  /// </remarks>
  public MsoSharedWorkspaceTaskPriority Priority { get; set; }
  /// <summary>
  /// Gets or sets the `Description` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.description?view=office-pia
  /// </remarks>
  public string Description { get; set; }
  /// <summary>
  /// Gets or sets the `DueDate` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.duedate?view=office-pia
  /// </remarks>
  public object DueDate { get; set; }
  /// <summary>
  /// Gets the `CreatedBy` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.createdby?view=office-pia
  /// </remarks>
  public string CreatedBy { get; }
  /// <summary>
  /// Gets the `CreatedDate` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.createddate?view=office-pia
  /// </remarks>
  public object CreatedDate { get; }
  /// <summary>
  /// Gets the `ModifiedBy` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.modifiedby?view=office-pia
  /// </remarks>
  public string ModifiedBy { get; }
  /// <summary>
  /// Gets the `ModifiedDate` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.modifieddate?view=office-pia
  /// </remarks>
  public object ModifiedDate { get; }
}
