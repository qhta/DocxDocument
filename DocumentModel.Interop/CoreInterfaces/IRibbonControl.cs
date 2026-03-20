
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the object passed into each Ribbon UI control callback procedure.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribboncontrol?view=office-pia
/// </remarks>
public partial interface IRibbonControl
{
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribboncontrol.id?view=office-pia
  /// </remarks>
  public string Id { get; }
  /// <summary>
  /// Gets the `Context` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribboncontrol.context?view=office-pia
  /// </remarks>
  public object Context { get; }
  /// <summary>
  /// Gets the `Tag` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribboncontrol.tag?view=office-pia
  /// </remarks>
  public string Tag { get; }
}
