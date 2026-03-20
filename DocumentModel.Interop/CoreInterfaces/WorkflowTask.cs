using System;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WorkflowTask` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask?view=office-pia
/// </remarks>
public partial interface WorkflowTask: InteropObject
{
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.id?view=office-pia
  /// </remarks>
  public string Id { get; }
  /// <summary>
  /// Gets the `ListID` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.listid?view=office-pia
  /// </remarks>
  public string ListID { get; }
  /// <summary>
  /// Gets the `WorkflowID` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.workflowid?view=office-pia
  /// </remarks>
  public string WorkflowID { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.description?view=office-pia
  /// </remarks>
  public string Description { get; }
  /// <summary>
  /// Gets the `AssignedTo` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.assignedto?view=office-pia
  /// </remarks>
  public string AssignedTo { get; }
  /// <summary>
  /// Gets the `CreatedBy` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.createdby?view=office-pia
  /// </remarks>
  public string CreatedBy { get; }
  /// <summary>
  /// Gets the `DueDate` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.duedate?view=office-pia
  /// </remarks>
  public DateTime DueDate { get; }
  /// <summary>
  /// Gets the `CreatedDate` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.createddate?view=office-pia
  /// </remarks>
  public DateTime CreatedDate { get; }
}
