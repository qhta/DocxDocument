
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WorkflowTemplate` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate?view=office-pia` for Office interop details.
/// </remarks>
public partial interface WorkflowTemplate: InteropObject
{
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate.id?view=office-pia
  /// </remarks>
  public string Id { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate.description?view=office-pia
  /// </remarks>
  public string Description { get; }
  /// <summary>
  /// Gets the `DocumentLibraryName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate.documentlibraryname?view=office-pia
  /// </remarks>
  public string DocumentLibraryName { get; }
  /// <summary>
  /// Gets the `DocumentLibraryURL` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate.documentlibraryurl?view=office-pia
  /// </remarks>
  public string DocumentLibraryURL { get; }
}
