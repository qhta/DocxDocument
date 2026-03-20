using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a custom or built-in document property.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty?view=office-pia
/// </remarks>
public partial interface DocumentProperty
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty.name?view=office-pia
  /// </remarks>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `Value` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty.value?view=office-pia
  /// </remarks>
  public object Value { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty.type?view=office-pia
  /// </remarks>
  public MsoDocProperties Type { get; set; }
  /// <summary>
  /// Gets or sets the `LinkToContent` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty.linktocontent?view=office-pia
  /// </remarks>
  public bool LinkToContent { get; set; }
  /// <summary>
  /// Gets or sets the `LinkSource` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty.linksource?view=office-pia
  /// </remarks>
  public string LinkSource { get; set; }
}
