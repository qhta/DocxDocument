
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the object passed into each Ribbon UI control callback procedure.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribboncontrol?view=office-pia"/>
public partial class IRibbonControl
{
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribboncontrol.id?view=office-pia"/>
  public string Id { get; }
  /// <summary>
  /// Gets the `Context` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribboncontrol.context?view=office-pia"/>
  public object Context { get; }
  /// <summary>
  /// Gets the `Tag` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribboncontrol.tag?view=office-pia"/>
  public string Tag { get; }
}

