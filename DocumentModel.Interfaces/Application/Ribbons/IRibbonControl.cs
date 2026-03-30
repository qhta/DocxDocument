
namespace DocumentModel.Application;

/// <summary>
/// Represents the object passed into each Ribbon UI control callback procedure.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribboncontrol?view=office-pia"/>
public partial interface IRibbonControl: IModelObject
{
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribboncontrol.id?view=office-pia"/>
  public string Id { get; }
  /// <summary>
  /// Gets the `Context` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribboncontrol.context?view=office-pia"/>
  public object Context { get; }
  /// <summary>
  /// Gets the `Tag` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribboncontrol.tag?view=office-pia"/>
  public string Tag { get; }
}

