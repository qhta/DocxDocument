using System;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WorkflowTask` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask?view=office-pia"/>
public interface IWorkflowTask: IInteropObject
{
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.id?view=office-pia"/>
  public string Id { get; }
  /// <summary>
  /// Gets the `ListID` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.listid?view=office-pia"/>
  public string ListID { get; }
  /// <summary>
  /// Gets the `WorkflowID` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.workflowid?view=office-pia"/>
  public string WorkflowID { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.description?view=office-pia"/>
  public string Description { get; }
  /// <summary>
  /// Gets the `AssignedTo` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.assignedto?view=office-pia"/>
  public string AssignedTo { get; }
  /// <summary>
  /// Gets the `CreatedBy` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.createdby?view=office-pia"/>
  public string CreatedBy { get; }
  /// <summary>
  /// Gets the `DueDate` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.duedate?view=office-pia"/>
  public DateTime DueDate { get; }
  /// <summary>
  /// Gets the `CreatedDate` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.createddate?view=office-pia"/>
  public DateTime CreatedDate { get; }


  #region methods

/// <summary>
  /// Invokes `Show`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.show?view=office-pia"/>
  public int Show();

  #endregion methods
}

