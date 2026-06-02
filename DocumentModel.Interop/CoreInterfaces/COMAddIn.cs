using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a COM add-in in the Microsoft Office host application.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddin?view=office-pia"/>
public interface ICOMAddIn: IInteropObject
{
  /// <summary>
  /// Gets or sets the `Description` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddin.description?view=office-pia"/>
  public string Description { get; set; }
  /// <summary>
  /// Gets the `ProgId` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddin.progid?view=office-pia"/>
  public string ProgId { get; }
  /// <summary>
  /// Gets the `Guid` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddin.guid?view=office-pia"/>
  public string Guid { get; }
  /// <summary>
  /// Gets or sets the `Connect` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddin.connect?view=office-pia"/>
  public bool Connect { get; set; }
  /// <summary>
  /// Gets or sets the `Object` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddin.object?view=office-pia"/>
  public object Object { get; set; }
}

