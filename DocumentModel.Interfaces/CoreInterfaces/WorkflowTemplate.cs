
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WorkflowTemplate` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate?view=office-pia"/>
public partial interface WorkflowTemplate: InteropObject
{
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate.id?view=office-pia"/>
  public string Id { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate.description?view=office-pia"/>
  public string Description { get; }
  /// <summary>
  /// Gets the `DocumentLibraryName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate.documentlibraryname?view=office-pia"/>
  public string DocumentLibraryName { get; }
  /// <summary>
  /// Gets the `DocumentLibraryURL` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate.documentlibraryurl?view=office-pia"/>
  public string DocumentLibraryURL { get; }
}

