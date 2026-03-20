using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a COM add-in in the Microsoft Office host application.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddin?view=office-pia
/// </remarks>
public partial interface COMAddIn: InteropObject
{
  /// <summary>
  /// Gets or sets the `Description` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddin.description?view=office-pia
  /// </remarks>
  public string Description { get; set; }
  /// <summary>
  /// Gets the `ProgId` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddin.progid?view=office-pia
  /// </remarks>
  public string ProgId { get; }
  /// <summary>
  /// Gets the `Guid` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddin.guid?view=office-pia
  /// </remarks>
  public string Guid { get; }
  /// <summary>
  /// Gets or sets the `Connect` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddin.connect?view=office-pia
  /// </remarks>
  public bool Connect { get; set; }
  /// <summary>
  /// Gets or sets the `Object` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddin.object?view=office-pia
  /// </remarks>
  public object Object { get; set; }
}
