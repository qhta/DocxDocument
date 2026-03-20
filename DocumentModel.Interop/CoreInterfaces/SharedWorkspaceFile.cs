using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceFile` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceFile: InteropObject
{
  /// <summary>
  /// Gets the `URL` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile.url?view=office-pia
  /// </remarks>
  public string URL { get; }
  /// <summary>
  /// Gets the `CreatedBy` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile.createdby?view=office-pia
  /// </remarks>
  public string CreatedBy { get; }
  /// <summary>
  /// Gets the `CreatedDate` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile.createddate?view=office-pia
  /// </remarks>
  public object CreatedDate { get; }
  /// <summary>
  /// Gets the `ModifiedBy` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile.modifiedby?view=office-pia
  /// </remarks>
  public string ModifiedBy { get; }
  /// <summary>
  /// Gets the `ModifiedDate` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefile.modifieddate?view=office-pia
  /// </remarks>
  public object ModifiedDate { get; }
}
